using LiveCharts.Definitions.Charts;
using MailKit.Net.Smtp;
using Microsoft.Data.SqlClient;
using MimeKit;
using QuestPDF.Drawing;
using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PdfColors = QuestPDF.Helpers.Colors;
using ScottPlotColors = ScottPlot.Colors;

namespace ProyectoFinal4S
{
    public partial class FrmDataSet : Form
    {
        private List<string[]> allRows = new List<string[]>();
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=NASA;Trusted_connection=yes; TrustServerCertificate=true";
        public FrmDataSet()
        {

            InitializeComponent();
            cmbViewOption.Items.Clear();
            cmbViewOption.Items.AddRange(new string[] { "Table", "Txt plain" });
            cmbViewOption.SelectedIndex = 0;
            cmbViewOption.SelectedIndexChanged += cmbViewOption_SelectedIndexChanged;
            txtPlainText.Visible = false;
            this.Load += Form2_Load;
            btnFilterClass.Click += btnFilterClass_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbClassFilter.Items.Clear();
            cmbClassFilter.Items.AddRange(new string[] { "ALL", "STAR", "GALAXY", "QSO" });
            cmbClassFilter.SelectedIndex = 0; // Por defecto "TODOS"

            cmbExportFormat.Items.Clear();
            cmbExportFormat.Items.AddRange(new string[] { "CSV", "TXT", "JSON", "XML" });
            cmbExportFormat.SelectedIndex = 0;

            cmbDeleteType.Items.Clear();
            cmbDeleteType.Items.AddRange(new string[] { "Row", "Column" });
            cmbDeleteType.SelectedIndex = 0;
        }
        // Método para convertir los datos a texto plano
        private string ConvertToPlainText()
        {
            var sb = new StringBuilder();

            // Encabezados
            var headers = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
            sb.AppendLine(string.Join("\t", headers));  // Tab para separar columnas

            // Filas
            foreach (var row in allRows)
            {
                sb.AppendLine(string.Join("\t", row));
            }
            return sb.ToString();
        }

        // Evento cambio de vista
        private void cmbViewOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cmbViewOption.SelectedItem.ToString();

            if (option == "Txt plain")
            {
                txtPlainText.Text = ConvertToPlainText();
                txtPlainText.Visible = true;
                dgvData.Visible = false;
            }
            else if (option == "Table")
            {
                txtPlainText.Visible = false;
                dgvData.Visible = true;
            }
        }
        private void LoadSQLData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los registros de la tabla dbo.Skyserver
                    string query = "SELECT * FROM dbo.Skyserver";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvData.Rows.Clear();
                        dgvData.Columns.Clear();
                        allRows.Clear();  // Limpiar los datos almacenados en memoria

                        // Agregar las columnas al DataGridView
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dgvData.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }

                        // Cargar las filas en allRows y en el DataGridView
                        while (reader.Read())
                        {
                            var row = new string[reader.FieldCount];  // Crear un array de string[] para cada fila
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader[i].ToString();  // Convertir cada valor a string
                            }

                            allRows.Add(row);  // Guardar la fila como string[] en allRows
                            dgvData.Rows.Add(row);  // Mostrar la fila en el DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV and TXT files (*.csv;*.txt)|*.csv;*.txt";
            openFileDialog.Title = "Open file";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            try
            {
                var lines = File.ReadAllLines(filePath);

                dgvData.Rows.Clear();
                dgvData.Columns.Clear();
                allRows.Clear();

                if (lines.Length > 0)
                {
                    char delimiter = ',';
                    var headers = lines[0].Split(delimiter);
                    foreach (var header in headers)
                    {
                        dgvData.Columns.Add(header, header);
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        var row = lines[i].Split(delimiter);
                        allRows.Add(row);
                    }

                    DisplayRows(allRows);
                    LlenarTreeView(allRows);
                    CountData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }
        // Función para mostrar filas en DataGridView
        private void DisplayRows(List<string[]> rows)
        {
            dgvData.Rows.Clear();
            foreach (var row in rows)
            {
                dgvData.Rows.Add(row);
            }
        }
        private void LlenarTreeView(List<string[]> rows)
        {

            treeView.Nodes.Clear(); // Limpiar los nodos existentes

            // Agrupar las filas por "class" (o cualquier otro campo que elijas)
            var agrupadoPorClase = rows.GroupBy(row => row[ObtenerIndiceColumna("class")]).ToList();

            foreach (var grupoClase in agrupadoPorClase)
            {
                // Crear el nodo raíz basado en la clase
                TreeNode nodoClase = new TreeNode(grupoClase.Key); // "class" (por ejemplo, "QSO", "STAR", "GALAXY")
                treeView.Nodes.Add(nodoClase);

                // Agrupar por "objid" (ID del objeto)
                var agrupadoPorObjid = grupoClase
                    .GroupBy(row => row[ObtenerIndiceColumna("objid")])
                    .ToList();

                foreach (var grupoObjid in agrupadoPorObjid)
                {
                    // Crear un nodo para el "objid"
                    TreeNode nodoObjid = new TreeNode($"Objid: {grupoObjid.Key}");
                    nodoClase.Nodes.Add(nodoObjid);

                    // Agregar el RA y DEC bajo el objeto
                    foreach (var item in grupoObjid)
                    {
                        string ra = item[ObtenerIndiceColumna("ra")]; // Right Ascension
                        string dec = item[ObtenerIndiceColumna("dec")]; // Declination
                        TreeNode nodoCoordenadas = new TreeNode($"RA: {ra}, DEC: {dec}");
                        nodoObjid.Nodes.Add(nodoCoordenadas);
                    }
                }
            }

        }
        // Función auxiliar para obtener el índice de una columna por su nombre
        private int ObtenerIndiceColumna(string nombreColumna)
        {
            // Asumiendo que los datos provienen de un CSV y tienen encabezados
            var encabezados = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText).ToList();
            return encabezados.IndexOf(nombreColumna);
        }

        private void btnFilterClass_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbClassFilter.SelectedItem.ToString();

            // Buscar índice de la columna "class"
            int indexClass = dgvData.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(col => col.HeaderText.Equals("class", StringComparison.OrdinalIgnoreCase))?.Index ?? -1;

            if (indexClass == -1)
            {
                MessageBox.Show("No se encontró la columna 'class'.");
                return;
            }

            // Mostrar todas las filas si seleccionó "TODOS"
            if (filtroSeleccionado.Equals("TODOS", StringComparison.OrdinalIgnoreCase))
            {
                DisplayRows(allRows);
                return;
            }

            // Filtrar filas que coincidan exactamente con el filtro seleccionado (insensible a mayúsculas)
            var filasFiltradas = allRows.Where(row =>
                row.Length > indexClass &&
                row[indexClass].Equals(filtroSeleccionado, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            DisplayRows(filasFiltradas);

            //string filtroSeleccionado = cmbClassFilter.SelectedItem.ToString();

            //// Buscar índice de la columna "class"
            //int indexClass = -1;
            //foreach (DataGridViewColumn col in dgvData.Columns)
            //{
            //    if (col.HeaderText.Equals("class", StringComparison.OrdinalIgnoreCase))
            //    {
            //        indexClass = col.Index;
            //        break;
            //    }
            //}

            //if (indexClass == -1)
            //{
            //    MessageBox.Show("No se encontró la columna 'class'.");
            //    return;
            //}

            //// Mostrar todas las filas si seleccionó "TODOS"
            //if (filtroSeleccionado.Equals("TODOS", StringComparison.OrdinalIgnoreCase))
            //{
            //    DisplayRows(allRows);
            //    return;
            //}

            //// Filtrar filas que coincidan exactamente con el filtro seleccionado (insensible a mayúsculas)
            //var filasFiltradas = allRows.Where(row =>
            //    row.Length > indexClass &&
            //    row[indexClass].Equals(filtroSeleccionado, StringComparison.OrdinalIgnoreCase)
            //).ToList();

            //DisplayRows(filasFiltradas);
            //CountData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cmbExportFormat.SelectedItem == null)
                return;

            string formato = cmbExportFormat.SelectedItem.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            switch (formato)
            {
                case "CSV":
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    saveFileDialog.Title = "Exportar a CSV";
                    break;
                case "TXT":
                    saveFileDialog.Filter = "TXT files (*.txt)|*.txt";
                    saveFileDialog.Title = "Exportar a TXT";
                    break;
                case "JSON":
                    saveFileDialog.Filter = "JSON files (*.json)|*.json";
                    saveFileDialog.Title = "Exportar a JSON";
                    break;
                case "XML":
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    saveFileDialog.Title = "Exportar a XML";
                    break;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;

            try
            {
                switch (formato)
                {
                    case "CSV":
                        GuardarArchivoCSV(ruta);
                        break;
                    case "TXT":
                        GuardarArchivoTXT(ruta);
                        break;
                    case "JSON":
                        ExportarAJSON(ruta);
                        break;
                    case "XML":
                        ExportarAXML(ruta);
                        break;
                }
                MessageBox.Show($"Archivo exportado correctamente en formato {formato}.");

                // Abrir el archivo con la aplicación predeterminada
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exportando archivo: " + ex.Message);
            }

        }

        public void GuardarArchivoCSV(string ruta)
        {
            var lines = new List<string>();

            var headers = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
            lines.Add(string.Join(",", headers));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>().Select(cell => EscapeForCsv(cell.Value?.ToString() ?? ""));
                    lines.Add(string.Join(",", cells));
                }
            }

            File.WriteAllLines(ruta, lines);
        }
        private string EscapeForCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }
            return value;
        }

        public void GuardarArchivoTXT(string ruta)
        {
            var lines = new List<string>();

            var headers = dgvData.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
            lines.Add(string.Join("\t", headers));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                    lines.Add(string.Join("\t", cells));
                }
            }

            File.WriteAllLines(ruta, lines);
        }

        public void ExportarAJSON(string ruta)
        {
            var listaObjetos = new List<Dictionary<string, string>>();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dict = new Dictionary<string, string>();
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value?.ToString() ?? "";
                        dict[col.HeaderText] = valor;
                    }
                    listaObjetos.Add(dict);
                }
            }

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(listaObjetos, opciones);

            File.WriteAllText(ruta, jsonString);
        }

        public void ExportarAXML(string ruta)
        {
            var root = new XElement("Registros");

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow)
                {
                    var registro = new XElement("Registro");
                    foreach (DataGridViewColumn col in dgvData.Columns)
                    {
                        var valor = row.Cells[col.Index].Value?.ToString() ?? "";
                        registro.Add(new XElement(col.HeaderText, valor));
                    }
                    root.Add(registro);
                }
            }

            var doc = new XDocument(root);
            doc.Save(ruta);
        }
        // Función para enviar correo con archivo adjunto usando MailKit
        private void EnviarCorreo(string toEmail, string subject, string body, string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo adjunto no existe.");
                return;
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Rosalinda", "rosalindacedillo2017@gmail.com"));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = subject;

            var builder = new BodyBuilder { TextBody = body };
            builder.Attachments.Add(filePath);
            message.Body = builder.ToMessageBody();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("rosalindacedillo2017@gmail.com", "rqcs laqq upjg rypk");

                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentCell == null)
            {
                MessageBox.Show("Select a cell to delete the corresponding row or column.");
                return;
            }

            string opcion = cmbDeleteType.SelectedItem.ToString();

            if (opcion == "Fila")
            {
                int rowIndex = dgvData.CurrentCell.RowIndex;

                var confirm = MessageBox.Show($"¿Delete fila {rowIndex + 1}?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dgvData.Rows.RemoveAt(rowIndex);
                    CountData();
                    if (rowIndex < allRows.Count)
                        allRows.RemoveAt(rowIndex);
                }
            }
            else if (opcion == "Colum")
            {
                int colIndex = dgvData.CurrentCell.ColumnIndex;
                string colName = dgvData.Columns[colIndex].HeaderText;

                var confirm = MessageBox.Show($"¿Delete column '{colName}'?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dgvData.Columns.RemoveAt(colIndex);

                    // Actualizar allRows para eliminar esa columna
                    for (int i = 0; i < allRows.Count; i++)
                    {
                        var listRow = allRows[i].ToList();
                        if (colIndex < listRow.Count)
                            listRow.RemoveAt(colIndex);
                        allRows[i] = listRow.ToArray();
                    }
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Seguro que quieres limpiar toda la tabla?",
                                       "Confirmar limpieza",
                                       MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dgvData.Rows.Clear();
                dgvData.Columns.Clear();
                allRows.Clear();
            }
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            if (allRows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados.");
                return;
            }

            try
            {
                Dictionary<string, int> conteos = new Dictionary<string, int>
                {
                    { "STAR", 0 },
                    { "GALAXY", 0 },
                    { "QSO", 0 }
                };

                foreach (var fila in allRows)
                {
                    if (fila.Length > 13)
                    {
                        string clase = fila[13].Trim().ToUpper();

                        if (conteos.ContainsKey(clase))
                            conteos[clase]++;
                    }
                }

                string[] etiquetas = conteos.Keys.ToArray();
                double[] valores = conteos.Values.Select(c => (double)c).ToArray();

                GraphicPie(etiquetas, valores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al graficar: " + ex.Message);
            }

        }


        private void GraphicPie(string[] etiquetas, double[] valores)
        {
            var plt = formsPlot1.Plot;
            plt.Clear();

            var pie = plt.Add.Pie(valores);

            double total = valores.Sum();
            pie.ExplodeFraction = 0.1;
            pie.SliceLabelDistance = 0.5;

            for (int i = 0; i < pie.Slices.Count && i < etiquetas.Length; i++)
            {
                pie.Slices[i].LabelFontSize = 16; // tamaño dentro del pastel
                pie.Slices[i].Label = $"{valores[i]}"; // etiqueta dentro del pastel
                pie.Slices[i].LegendText = $"{etiquetas[i]} ({valores[i] / total:p1})"; // leyenda
            }

            pie.DonutFraction = 0;
            pie.Rotation = ScottPlot.Angle.FromDegrees(0);

            // Ocultar ejes y grilla para estética limpia
            plt.Axes.Frameless();
            plt.HideGrid();

            formsPlot1.Refresh();
        }

        private void btnScatterPlot_Click(object sender, EventArgs e)
        {
            if (allRows.Count == 0)
            {
                MessageBox.Show("There are no data loaded.");
                return;
            }

            try
            {
                List<double> raList = new List<double>();
                List<double> decList = new List<double>();
                int count = 0;

                foreach (var fila in allRows)
                {
                    if (fila.Length > 13 && fila[13].Trim().ToUpper() == "STAR")
                    {
                        if (double.TryParse(fila[1], out double ra) &&
                            double.TryParse(fila[2], out double dec))
                        {
                            raList.Add(ra);
                            decList.Add(dec);
                            count++;
                        }

                        if (count >= 1000)
                            break;
                    }
                }

                var plt = formsPlot2.Plot;
                plt.Clear();

                var scatter = plt.Add.ScatterPoints(raList.ToArray(), decList.ToArray());
                scatter.MarkerSize = 5;
                scatter.Color = ScottPlot.Colors.Blue;
                scatter.MarkerShape = MarkerShape.FilledCircle;

                plt.Title("Primeras 1000 Estrellas (RA vs DEC)");
                plt.XLabel("Ascensión Recta (ra)");
                plt.YLabel("Declinación (dec)");

                plt.Axes.SetLimits(0, 360, -90, 90);
                formsPlot2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in graphing stars: " + ex.Message);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export..");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";
            saveFileDialog.FileName = "export.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = saveFileDialog.FileName;

            try
            {
                var headers = dgvData.Columns.Cast<DataGridViewColumn>()
                                .Select(c => c.HeaderText)
                                .ToList();

                var rows = new List<List<string>>();

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => cell.Value?.ToString() ?? "")
                            .ToList();

                        rows.Add(cells);
                    }
                }

                QuestPDF.Settings.License = LicenseType.Community;

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(30);
                        page.Size(PageSizes.A4);
                        page.PageColor(QuestPDF.Helpers.Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(9));

                        page.Content().Table(table =>
                        {
                            // Definir columnas
                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < headers.Count; i++)
                                    columns.RelativeColumn();
                            });

                            // Encabezados
                            table.Header(header =>
                            {
                                foreach (var headerText in headers)
                                {
                                    header.Cell()
                                          .Background(QuestPDF.Helpers.Colors.Grey.Lighten2)
                                          .Padding(5)
                                          .Text(headerText)
                                          .SemiBold()
                                          .FontColor(QuestPDF.Helpers.Colors.Blue.Darken2);
                                }
                            });

                            // Celdas de datoss
                            foreach (var row in rows)
                            {
                                foreach (var cell in row)
                                {
                                    table.Cell().Padding(5).Text(cell);
                                }
                            }
                        });
                    });
                });

                document.GeneratePdf(ruta);

                MessageBox.Show("PDF exported correctly.");
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string texto = txtSearch.Text.Trim().ToLower();
            int coincidencias = 0;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(texto))
                    {
                        cell.Style.BackColor = System.Drawing.Color.LightPink;
                        coincidencias++;
                    }
                    else
                    {
                        cell.Style.BackColor = System.Drawing.Color.White;
                    }
                }
            }

            MessageBox.Show($"{coincidencias} coincidencias encontradas.");
        }

        private void btnRedshift_Click(object sender, EventArgs e)
        {
            // Buscar índice de la columna "redshift"
            int indexRedshift = -1;

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col.HeaderText.Equals("redshift", StringComparison.OrdinalIgnoreCase))
                {
                    indexRedshift = col.Index;
                    break;
                }
            }

            if (indexRedshift == -1)
            {
                MessageBox.Show("The column 'redshift' was not found.'.");
                return;
            }

            // Ordenar
            List<string[]> OrdererRow;

            if (rbClose.Checked)
            {
                OrdererRow = allRows
                    .Where(row => row.Length > indexRedshift && double.TryParse(row[indexRedshift], out _))
                    .OrderBy(row => double.Parse(row[indexRedshift]))
                    .ToList();

                MessageBox.Show("Sorted by closest objects (low redshift).");
            }
            else if (rbDistant.Checked)
            {
                OrdererRow = allRows
                    .Where(row => row.Length > indexRedshift && double.TryParse(row[indexRedshift], out _))
                    .OrderByDescending(row => double.Parse(row[indexRedshift]))
                    .ToList();

                MessageBox.Show("Sorted by most distant objects (high redshift).");
            }
            else
            {
                MessageBox.Show("Select an order option: Near or Far.");
                return;
            }

            // Mostrar resultado en el DataGridView
            DisplayRows(OrdererRow);
            CountData();
        }


        private void CountData()
        {
            int total = dgvData.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
            lblData.Text = $"Data: {total}";
        }

        private void btnsqlDate_Click(object sender, EventArgs e)
        {
            LoadSQLData();
        }

        private void btnSaveSqlChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Hacer visible la barra de progreso y configurarla
                pgb.Visible = true;
                pgb.Value = 0;
                pgb.Maximum = dgvData.Rows.Count - 1;  // Establecer el máximo al número de filas del DataGridView

                lblProgress.Text = "Processing..."; // Mostrar el mensaje de progreso

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 1. Verificar si la tabla existe, y si no, crearla
                    string checkTableQuery = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Skyserver_Updated' AND xtype = 'U') " +
                                             "BEGIN " +
                                             "CREATE TABLE dbo.Skyserver_Updated (" +
                                             "objid FLOAT, " +
                                             "ra FLOAT, " +
                                             "dec FLOAT, " +
                                             "u FLOAT, " +
                                             "g FLOAT, " +
                                             "r FLOAT, " +
                                             "i FLOAT, " +
                                             "z FLOAT, " +
                                             "run INT, " +
                                             "rerun INT, " +
                                             "camcol INT, " +
                                             "field INT, " +
                                             "specobjid FLOAT, " +
                                             "class VARCHAR(50), " +
                                             "redshift FLOAT, " +
                                             "plate INT, " +
                                             "mjd INT, " +
                                             "fiberid INT " +
                                             ") " +
                                             "END";

                    using (SqlCommand command = new SqlCommand(checkTableQuery, connection))
                    {
                        command.ExecuteNonQuery();  // Ejecutar la consulta para crear la tabla si no existe
                    }

                    // 2. Crear la nueva DataTable con los datos modificados
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("objid", typeof(double));
                    dataTable.Columns.Add("ra", typeof(double));
                    dataTable.Columns.Add("dec", typeof(double));
                    dataTable.Columns.Add("u", typeof(double));
                    dataTable.Columns.Add("g", typeof(double));
                    dataTable.Columns.Add("r", typeof(double));
                    dataTable.Columns.Add("i", typeof(double));
                    dataTable.Columns.Add("z", typeof(double));
                    dataTable.Columns.Add("run", typeof(int));
                    dataTable.Columns.Add("rerun", typeof(int));
                    dataTable.Columns.Add("camcol", typeof(int));
                    dataTable.Columns.Add("field", typeof(int));
                    dataTable.Columns.Add("specobjid", typeof(double));
                    dataTable.Columns.Add("class", typeof(string));
                    dataTable.Columns.Add("redshift", typeof(double)); // Usamos Double para redshift
                    dataTable.Columns.Add("plate", typeof(int));
                    dataTable.Columns.Add("mjd", typeof(int));
                    dataTable.Columns.Add("fiberid", typeof(int));

                    // 3. Recorrer el DataGridView y agregar los datos modificados a la DataTable
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            DataRow dataRow = dataTable.NewRow();

                            // Validar y asignar cada columna numérica
                            dataRow["objid"] = ValidateConvertDouble(row.Cells["objid"].Value);
                            dataRow["ra"] = ValidateConvertDouble(row.Cells["ra"].Value);
                            dataRow["dec"] = ValidateConvertDouble(row.Cells["dec"].Value);
                            dataRow["u"] = ValidateConvertDouble(row.Cells["u"].Value);
                            dataRow["g"] = ValidateConvertDouble(row.Cells["g"].Value);
                            dataRow["r"] = ValidateConvertDouble(row.Cells["r"].Value);
                            dataRow["i"] = ValidateConvertDouble(row.Cells["i"].Value);
                            dataRow["z"] = ValidateConvertDouble(row.Cells["z"].Value);

                            // Las columnas que no son numéricas no necesitan validación adicional
                            dataRow["run"] = row.Cells["run"].Value;
                            dataRow["rerun"] = row.Cells["rerun"].Value;
                            dataRow["camcol"] = row.Cells["camcol"].Value;
                            dataRow["field"] = row.Cells["field"].Value;
                            dataRow["specobjid"] = ValidateConvertDouble(row.Cells["specobjid"].Value);
                            dataRow["class"] = row.Cells["class"].Value;
                            dataRow["redshift"] = ValidateConvertDouble(row.Cells["redshift"].Value);
                            dataRow["plate"] = row.Cells["plate"].Value;
                            dataRow["mjd"] = row.Cells["mjd"].Value;
                            dataRow["fiberid"] = row.Cells["fiberid"].Value;

                            dataTable.Rows.Add(dataRow);
                        }

                        // Actualizar la barra de progreso y asegurarse de que no se pase del máximo
                        if (pgb.Value < pgb.Maximum)
                        {
                            pgb.Value += 1; // Aumentar el valor
                        }
                        else
                        {
                            pgb.Value = pgb.Maximum; // Asegurar que no se pase del máximo
                        }
                    }

                    // 4. Usar SqlBulkCopy para insertar los datos en la nueva tabla "Skyserver_Updated"
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "dbo.Skyserver_Updated";  // Nombre de la nueva tabla
                        bulkCopy.WriteToServer(dataTable);  // Insertar los datos
                    }

                    // Mensaje de éxito
                    MessageBox.Show("Loaded correctly.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating the table or inserting the data: " + ex.Message);
            }
            finally
            {
                // Ocultar la barra de progreso al terminar
                pgb.Visible = false;
                lblProgress.Visible = false;
            }
        }
        private double ValidateConvertDouble(object value)
        {
            double result;
            if (value != null && double.TryParse(value.ToString(), out result))
            {
                return result;
            }
            return 0.0; // Valor predeterminado si no es un número válido
        }

        private void btnEnviarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Mostrar todos los tipos de archivos que has permitido para exportar
                Filter = "CSV files (*.csv)|*.csv|TXT files (*.txt)|*.txt|JSON files (*.json)|*.json|XML files (*.xml)|*.xml|PDF files (*.pdf)|*.pdf",
                Title = "Seleccionar archivo para enviar por correo"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string ruta = openFileDialog.FileName;

            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo seleccionado no existe.");
                return;
            }

            try
            {
                EnviarCorreo("rosalindacedillo2017@gmail.com", "Archivo Exportado", "Aquí está el archivo exportado.", ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

    }
}
