Imports MailKit.Net.Smtp
Imports Microsoft.Data.SqlClient
Imports MimeKit
Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports QuestPDF.Infrastructure
Imports ScottPlot
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Text.Json
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports PdfColors = QuestPDF.Helpers.Colors
Imports ScottPlotColors = ScottPlot.Colors

Namespace ProyectoFinal4S
    Public Partial Class FrmDataSet
        Inherits Form
        Private allRows As List(Of String()) = New List(Of String())()
        Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=NASA;Trusted_connection=yes; TrustServerCertificate=true"
        Public Sub New()
            InitializeComponent()
            cmbViewOption.Items.Clear()
            cmbViewOption.Items.AddRange(New String() {"Table", "Txt plain"})
            cmbViewOption.SelectedIndex = 0
            AddHandler cmbViewOption.SelectedIndexChanged, AddressOf cmbViewOption_SelectedIndexChanged
            txtPlainText.Visible = False
            AddHandler Load, AddressOf Form2_Load
            AddHandler btnFilterClass.Click, AddressOf btnFilterClass_Click
        End Sub

        Private Sub Form2_Load(sender As Object, e As EventArgs)
            cmbClassFilter.Items.Clear()
            cmbClassFilter.Items.AddRange(New String() {"ALL", "STAR", "GALAXY", "QSO"})
            cmbClassFilter.SelectedIndex = 0 ' Por defecto "TODOS"

            cmbExportFormat.Items.Clear()
            cmbExportFormat.Items.AddRange(New String() {"CSV", "TXT", "JSON", "XML"})
            cmbExportFormat.SelectedIndex = 0

            cmbDeleteType.Items.Clear()
            cmbDeleteType.Items.AddRange(New String() {"Row", "Column"})
            cmbDeleteType.SelectedIndex = 0
        End Sub
        ' Método para convertir los datos a texto plano
        Private Function ConvertToPlainText() As String
            Dim sb = New StringBuilder()

            ' Encabezados
            Dim headers = dgvData.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText)
            sb.AppendLine(String.Join(vbTab, headers))  ' Tab para separar columnas

            ' Filas
            For Each row In allRows
                sb.AppendLine(String.Join(vbTab, row))
            Next
            Return sb.ToString()
        End Function

        ' Evento cambio de vista
        Private Sub cmbViewOption_SelectedIndexChanged(sender As Object, e As EventArgs)
            Dim [option] As String = cmbViewOption.SelectedItem.ToString()

            If Equals([option], "Txt plain") Then
                txtPlainText.Text = ConvertToPlainText()
                txtPlainText.Visible = True
                dgvData.Visible = False
            ElseIf Equals([option], "Table") Then
                txtPlainText.Visible = False
                dgvData.Visible = True
            End If
        End Sub
        Private Sub LoadSQLData()
            Try
                Using connection As SqlConnection = New SqlConnection(connectionString)
                    connection.Open()

                    ' Consulta SQL para obtener todos los registros de la tabla dbo.Skyserver
                    Dim query = "SELECT * FROM dbo.Skyserver"

                    Using command As SqlCommand = New SqlCommand(query, connection)
                        Using reader As SqlDataReader = command.ExecuteReader()
                            dgvData.Rows.Clear()
                            dgvData.Columns.Clear()
                            allRows.Clear()  ' Limpiar los datos almacenados en memoria

                            ' Agregar las columnas al DataGridView
                            For i = 0 To reader.FieldCount - 1
                                dgvData.Columns.Add(reader.GetName(i), reader.GetName(i))
                            Next

                            ' Cargar las filas en allRows y en el DataGridView
                            While reader.Read()
                                Dim row = New String(reader.FieldCount - 1) {}  ' Crear un array de string[] para cada fila
                                For i = 0 To reader.FieldCount - 1
                                    row(i) = reader(i).ToString()  ' Convertir cada valor a string
                                Next

                                allRows.Add(row)  ' Guardar la fila como string[] en allRows
                                dgvData.Rows.Add(row)  ' Mostrar la fila en el DataGridView
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos desde la base de datos: " & ex.Message)
            End Try
        End Sub

        Private Sub btnOpen_Click(sender As Object, e As EventArgs)

            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "CSV and TXT files (*.csv;*.txt)|*.csv;*.txt"
            openFileDialog.Title = "Open file"

            If openFileDialog.ShowDialog() <> DialogResult.OK Then Return

            Dim filePath = openFileDialog.FileName

            Try
                Dim lines = File.ReadAllLines(filePath)

                dgvData.Rows.Clear()
                dgvData.Columns.Clear()
                allRows.Clear()

                If lines.Length > 0 Then
                    Dim delimiter = ","c
                    Dim headers = lines(0).Split(delimiter)
                    For Each header In headers
                        dgvData.Columns.Add(header, header)
                    Next

                    For i = 1 To lines.Length - 1
                        Dim row = lines(i).Split(delimiter)
                        allRows.Add(row)
                    Next

                    DisplayRows(allRows)
                    LlenarTreeView(allRows)
                    CountData()
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try

        End Sub
        ' Función para mostrar filas en DataGridView
        Private Sub DisplayRows(rows As List(Of String()))
            dgvData.Rows.Clear()
            For Each row In rows
                dgvData.Rows.Add(row)
            Next
        End Sub
        Private Sub LlenarTreeView(rows As List(Of String()))

            treeView.Nodes.Clear() ' Limpiar los nodos existentes

            ' Agrupar las filas por "class" (o cualquier otro campo que elijas)
            Dim agrupadoPorClase = rows.GroupBy(Function(row) row(ObtenerIndiceColumna("class"))).ToList()

            For Each grupoClase In agrupadoPorClase
                ' Crear el nodo raíz basado en la clase
                Dim nodoClase As TreeNode = New TreeNode(grupoClase.Key) ' "class" (por ejemplo, "QSO", "STAR", "GALAXY")
                treeView.Nodes.Add(nodoClase)

                ' Agrupar por "objid" (ID del objeto)
                Dim agrupadoPorObjid = grupoClase.GroupBy(Function(row) row(ObtenerIndiceColumna("objid"))).ToList()

                For Each grupoObjid In agrupadoPorObjid
                    ' Crear un nodo para el "objid"
                    Dim nodoObjid As TreeNode = New TreeNode($"Objid: {grupoObjid.Key}")
                    nodoClase.Nodes.Add(nodoObjid)

                    ' Agregar el RA y DEC bajo el objeto
                    For Each item In grupoObjid
                        Dim ra = item(ObtenerIndiceColumna("ra")) ' Right Ascension
                        Dim dec = item(ObtenerIndiceColumna("dec")) ' Declination
                        Dim nodoCoordenadas As TreeNode = New TreeNode($"RA: {ra}, DEC: {dec}")
                        nodoObjid.Nodes.Add(nodoCoordenadas)
                    Next
                Next
            Next

        End Sub
        ' Función auxiliar para obtener el índice de una columna por su nombre
        Private Function ObtenerIndiceColumna(nombreColumna As String) As Integer
            ' Asumiendo que los datos provienen de un CSV y tienen encabezados
            Dim encabezados = dgvData.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText).ToList()
            Return encabezados.IndexOf(nombreColumna)
        End Function

        Private Sub btnFilterClass_Click(sender As Object, e As EventArgs)
            Dim filtroSeleccionado As String = cmbClassFilter.SelectedItem.ToString()

            ' Buscar índice de la columna "class"
            Dim indexClass As Integer = If(dgvData.Columns.Cast(Of DataGridViewColumn)().FirstOrDefault(Function(col) col.HeaderText.Equals("class", StringComparison.OrdinalIgnoreCase))?.Index, -1)

            If indexClass = -1 Then
                MessageBox.Show("No se encontró la columna 'class'.")
                Return
            End If

            ' Mostrar todas las filas si seleccionó "TODOS"
            If filtroSeleccionado.Equals("TODOS", StringComparison.OrdinalIgnoreCase) Then
                DisplayRows(allRows)
                Return
            End If

            ' Filtrar filas que coincidan exactamente con el filtro seleccionado (insensible a mayúsculas)
            Dim filasFiltradas = allRows.Where(Function(row) row.Length > indexClass AndAlso row(indexClass).Equals(filtroSeleccionado, StringComparison.OrdinalIgnoreCase)).ToList()

            DisplayRows(filasFiltradas)


        End Sub

        Private Sub btnExport_Click(sender As Object, e As EventArgs)
            If cmbExportFormat.SelectedItem Is Nothing Then Return

            Dim formato As String = cmbExportFormat.SelectedItem.ToString()

            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            Select Case formato
                Case "CSV"
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
                    saveFileDialog.Title = "Exportar a CSV"
                Case "TXT"
                    saveFileDialog.Filter = "TXT files (*.txt)|*.txt"
                    saveFileDialog.Title = "Exportar a TXT"
                Case "JSON"
                    saveFileDialog.Filter = "JSON files (*.json)|*.json"
                    saveFileDialog.Title = "Exportar a JSON"
                Case "XML"
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml"
                    saveFileDialog.Title = "Exportar a XML"
            End Select

            If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

            Dim ruta = saveFileDialog.FileName

            Try
                Select Case formato
                    Case "CSV"
                        GuardarArchivoCSV(ruta)
                    Case "TXT"
                        GuardarArchivoTXT(ruta)
                    Case "JSON"
                        ExportarAJSON(ruta)
                    Case "XML"
                        ExportarAXML(ruta)
                End Select
                MessageBox.Show($"Archivo exportado correctamente en formato {formato}.")

                ' Abrir el archivo con la aplicación predeterminada
                Call Process.Start(New ProcessStartInfo() With {
    .FileName = ruta,
    .UseShellExecute = True
})
            Catch ex As Exception
                MessageBox.Show("Error exportando archivo: " & ex.Message)
            End Try

        End Sub

        Public Sub GuardarArchivoCSV(ruta As String)
            Dim lines = New List(Of String)()

            Dim headers = dgvData.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText)
            lines.Add(String.Join(",", headers))

            For Each row As DataGridViewRow In dgvData.Rows
                If Not row.IsNewRow Then
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().[Select](Function(cell) EscapeForCsv(If(cell.Value?.ToString(), "")))
                    lines.Add(String.Join(",", cells))
                End If
            Next

            File.WriteAllLines(ruta, lines)
        End Sub
        Private Function EscapeForCsv(value As String) As String
            If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(vbLf) Then
                value = value.Replace("""", """""")
                Return $"""{value}"""
            End If
            Return value
        End Function

        Public Sub GuardarArchivoTXT(ruta As String)
            Dim lines = New List(Of String)()

            Dim headers = dgvData.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText)
            lines.Add(String.Join(vbTab, headers))

            For Each row As DataGridViewRow In dgvData.Rows
                If Not row.IsNewRow Then
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().[Select](Function(cell) If(cell.Value?.ToString(), ""))
                    lines.Add(String.Join(vbTab, cells))
                End If
            Next

            File.WriteAllLines(ruta, lines)
        End Sub

        Public Sub ExportarAJSON(ruta As String)
            Dim listaObjetos = New List(Of Dictionary(Of String, String))()

            For Each row As DataGridViewRow In dgvData.Rows
                If Not row.IsNewRow Then
                    Dim dict = New Dictionary(Of String, String)()
                    For Each col As DataGridViewColumn In dgvData.Columns
                        Dim valor = If(row.Cells(col.Index).Value?.ToString(), "")
                        dict(col.HeaderText) = valor
                    Next
                    listaObjetos.Add(dict)
                End If
            Next

            Dim opciones = New JsonSerializerOptions With {
                .WriteIndented = True
            }
            Dim jsonString = JsonSerializer.Serialize(listaObjetos, opciones)

            File.WriteAllText(ruta, jsonString)
        End Sub

        Public Sub ExportarAXML(ruta As String)
            Dim root = New XElement("Registros")

            For Each row As DataGridViewRow In dgvData.Rows
                If Not row.IsNewRow Then
                    Dim registro = New XElement("Registro")
                    For Each col As DataGridViewColumn In dgvData.Columns
                        Dim valor = If(row.Cells(col.Index).Value?.ToString(), "")
                        registro.Add(New XElement(col.HeaderText, valor))
                    Next
                    root.Add(registro)
                End If
            Next

            Dim doc = New XDocument(root)
            doc.Save(ruta)
        End Sub
        ' Función para enviar correo con archivo adjunto usando MailKit
        Private Sub EnviarCorreo(toEmail As String, subject As String, body As String, filePath As String)
            If Not File.Exists(filePath) Then
                MessageBox.Show("El archivo adjunto no existe.")
                Return
            End If

            Dim message = New MimeMessage()
            message.From.Add(New MailboxAddress("Rosalinda", "rosalindacedillo2017@gmail.com"))
            message.To.Add(MailboxAddress.Parse(toEmail))
            message.Subject = subject

            Dim builder = New BodyBuilder With {
                .TextBody = body
            }
            builder.Attachments.Add(filePath)
            message.Body = builder.ToMessageBody()

            Try
                Using client = New SmtpClient()
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls)
                    client.Authenticate("rosalindacedillo2017@gmail.com", "rqcs laqq upjg rypk")

                    client.Send(message)
                    client.Disconnect(True)
                End Using

                MessageBox.Show("Email sent successfully.")
            Catch ex As Exception
                MessageBox.Show("Error al enviar el correo: " & ex.Message)
            End Try
        End Sub
        Private Sub btnDelete_Click(sender As Object, e As EventArgs)
            If dgvData.CurrentCell Is Nothing Then
                MessageBox.Show("Select a cell to delete the corresponding row or column.")
                Return
            End If

            Dim opcion As String = cmbDeleteType.SelectedItem.ToString()

            If Equals(opcion, "Fila") Then
                Dim rowIndex = dgvData.CurrentCell.RowIndex

                Dim confirm = MessageBox.Show($"¿Delete fila {rowIndex + 1}?", "Confirm deletion", MessageBoxButtons.YesNo)
                If confirm = DialogResult.Yes Then
                    dgvData.Rows.RemoveAt(rowIndex)
                    CountData()
                    If rowIndex < allRows.Count Then allRows.RemoveAt(rowIndex)
                End If
            ElseIf Equals(opcion, "Colum") Then
                Dim colIndex = dgvData.CurrentCell.ColumnIndex
                Dim colName = dgvData.Columns(colIndex).HeaderText

                Dim confirm = MessageBox.Show($"¿Delete column '{colName}'?", "Confirm deletion", MessageBoxButtons.YesNo)
                If confirm = DialogResult.Yes Then
                    dgvData.Columns.RemoveAt(colIndex)

                    ' Actualizar allRows para eliminar esa columna
                    For i = 0 To allRows.Count - 1
                        Dim listRow = allRows(i).ToList()
                        If colIndex < listRow.Count Then listRow.RemoveAt(colIndex)
                        allRows(i) = listRow.ToArray()
                    Next
                End If
            End If
        End Sub

        Private Sub btnClearData_Click(sender As Object, e As EventArgs)
            Dim confirmResult = MessageBox.Show("¿Seguro que quieres limpiar toda la tabla?", "Confirmar limpieza", MessageBoxButtons.YesNo)

            If confirmResult = DialogResult.Yes Then
                dgvData.Rows.Clear()
                dgvData.Columns.Clear()
                allRows.Clear()
            End If
        End Sub


        Private Sub btnGoBack_Click(sender As Object, e As EventArgs)
            Dim menu As FrmMenu = New FrmMenu()
            menu.Show()
            Hide()
        End Sub

        Private Sub btnGraphics_Click(sender As Object, e As EventArgs)
            If allRows.Count = 0 Then
                MessageBox.Show("No hay datos cargados.")
                Return
            End If

            Try
                Dim conteos As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
    {"STAR", 0},
    {"GALAXY", 0},
    {"QSO", 0}
}

                For Each fila In allRows
                    If fila.Length > 13 Then
                        Dim clase As String = fila(13).Trim().ToUpper()

                        If conteos.ContainsKey(clase) Then conteos(clase) += 1
                    End If
                Next

                Dim etiquetas As String() = conteos.Keys.ToArray()
                Dim valores As Double() = conteos.Values.[Select](Function(c) CDbl(c)).ToArray()

                GraphicPie(etiquetas, valores)
            Catch ex As Exception
                MessageBox.Show("Error al graficar: " & ex.Message)
            End Try

        End Sub


        Private Sub GraphicPie(etiquetas As String(), valores As Double())
            Dim plt = formsPlot1.Plot
            plt.Clear()

            Dim pie = plt.Add.Pie(valores)

            Dim total As Double = valores.Sum()
            pie.ExplodeFraction = 0.1
            pie.SliceLabelDistance = 0.5

            Dim i = 0

            While i < pie.Slices.Count AndAlso i < etiquetas.Length
                pie.Slices(i).LabelFontSize = 16 ' tamaño dentro del pastel
                pie.Slices(i).Label = $"{valores(i)}" ' etiqueta dentro del pastel
                pie.Slices(i).LegendText = $"{etiquetas(i)} ({valores(i) / total:p1})" ' leyenda
                i += 1
            End While

            pie.DonutFraction = 0
            pie.Rotation = Angle.FromDegrees(0)

            ' Ocultar ejes y grilla para estética limpia
            plt.Axes.Frameless()
            plt.HideGrid()

            formsPlot1.Refresh()
        End Sub

        Private Sub btnScatterPlot_Click(sender As Object, e As EventArgs)
            If allRows.Count = 0 Then
                MessageBox.Show("There are no data loaded.")
                Return
            End If
            Dim ra As Double = Nothing, dec As Double = Nothing

            Try
                Dim raList As List(Of Double) = New List(Of Double)()
                Dim decList As List(Of Double) = New List(Of Double)()
                Dim count = 0

                For Each fila In allRows
                    If fila.Length > 13 AndAlso Equals(fila(13).Trim().ToUpper(), "STAR") Then
                        If Double.TryParse(fila(1), ra) AndAlso Double.TryParse(fila(2), dec) Then
                            raList.Add(ra)
                            decList.Add(dec)
                            count += 1
                        End If

                        If count >= 1000 Then Exit For
                    End If
                Next

                Dim plt = formsPlot2.Plot
                plt.Clear()

                Dim scatter = plt.Add.ScatterPoints(raList.ToArray(), decList.ToArray())
                scatter.MarkerSize = 5
                scatter.Color = ScottPlotColors.Blue
                scatter.MarkerShape = MarkerShape.FilledCircle

                plt.Title("Primeras 1000 Estrellas (RA vs DEC)")
                plt.XLabel("Ascensión Recta (ra)")
                plt.YLabel("Declinación (dec)")

                plt.Axes.SetLimits(0, 360, -90, 90)
                formsPlot2.Refresh()
            Catch ex As Exception
                MessageBox.Show("Error in graphing stars: " & ex.Message)
            End Try
        End Sub

        Private Sub btnExportPDF_Click(sender As Object, e As EventArgs)
            If dgvData.Rows.Count = 0 Then
                MessageBox.Show("There is no data to export..")
                Return
            End If

            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.Title = "Guardar como PDF"
            saveFileDialog.FileName = "export.pdf"

            If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

            Dim ruta = saveFileDialog.FileName

            Try
                Dim headers = dgvData.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText).ToList()

                Dim rows = New List(Of List(Of String))()

                For Each row As DataGridViewRow In dgvData.Rows
                    If Not row.IsNewRow Then
                        Dim cells = row.Cells.Cast(Of DataGridViewCell)().[Select](Function(cell) If(cell.Value?.ToString(), "")).ToList()

                        rows.Add(cells)
                    End If
                Next

                QuestPDF.Settings.License = LicenseType.Community

                Dim document = QuestPDF.Fluent.Document.Create(Sub(container)
                                                                   container.Page(Sub(page)
                                                                                      page.Margin(30)
                                                                                      page.Size(PageSizes.A4)
                                                                                      page.PageColor(PdfColors.White)
                                                                                      page.DefaultTextStyle(Function(x) x.FontSize(9))

                                                                                      page.Content().Table(Sub(table)
                                                                                                               ' Definir columnas
                                                                                                               table.ColumnsDefinition(Sub(columns)
                                                                                                                                           For i = 0 To headers.Count - 1
                                                                                                                                               columns.RelativeColumn()
                                                                                                                                           Next
                                                                                                                                       End Sub)

                                                                                                               ' Encabezados
                                                                                                               table.Header(Sub(header)
                                                                                                                                For Each headerText In headers
                                                                                                                                    header.Cell().Background(PdfColors.Grey.Lighten2).Padding(5).Text(headerText).SemiBold().FontColor(PdfColors.Blue.Darken2)
                                                                                                                                Next
                                                                                                                            End Sub)

                                                                                                               ' Celdas de datoss
                                                                                                               For Each row In rows
                                                                                                                   For Each cell In row
                                                                                                                       table.Cell().Padding(5).Text(cell)
                                                                                                                   Next
                                                                                                               Next
                                                                                                           End Sub)
                                                                                  End Sub)
                                                               End Sub)

                document.GeneratePdf(ruta)

                MessageBox.Show("PDF exported correctly.")
                Call Process.Start(New ProcessStartInfo() With {
    .FileName = ruta,
    .UseShellExecute = True
})
            Catch ex As Exception
                MessageBox.Show("Error exporting to PDF: " & ex.Message)
            End Try

        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs)
            Dim texto As String = txtSearch.Text.Trim().ToLower()
            Dim coincidencias = 0

            For Each row As DataGridViewRow In dgvData.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(texto) Then
                        cell.Style.BackColor = System.Drawing.Color.LightPink
                        coincidencias += 1
                    Else
                        cell.Style.BackColor = System.Drawing.Color.White
                    End If
                Next
            Next

            MessageBox.Show($"{coincidencias} coincidencias encontradas.")
        End Sub

        Private Sub btnRedshift_Click(sender As Object, e As EventArgs)
            ' Buscar índice de la columna "redshift"
            Dim indexRedshift = -1

            For Each col As DataGridViewColumn In dgvData.Columns
                If col.HeaderText.Equals("redshift", StringComparison.OrdinalIgnoreCase) Then
                    indexRedshift = col.Index
                    Exit For
                End If
            Next

            If indexRedshift = -1 Then
                MessageBox.Show("The column 'redshift' was not found.'.")
                Return
            End If

            ' Ordenar
            Dim OrdererRow As List(Of String())

            If rbClose.Checked Then
                OrdererRow = allRows.Where(Function(row) row.Length > indexRedshift AndAlso Double.TryParse(row(indexRedshift), __)).OrderBy(Function(row) Double.Parse(row(indexRedshift))).ToList()

                MessageBox.Show("Sorted by closest objects (low redshift).")
            ElseIf rbDistant.Checked Then
                OrdererRow = allRows.Where(Function(row) row.Length > indexRedshift AndAlso Double.TryParse(row(indexRedshift), __)).OrderByDescending(Function(row) Double.Parse(row(indexRedshift))).ToList()

                MessageBox.Show("Sorted by most distant objects (high redshift).")
            Else
                MessageBox.Show("Select an order option: Near or Far.")
                Return
            End If

            ' Mostrar resultado en el DataGridView
            DisplayRows(OrdererRow)
            CountData()
        End Sub


        Private Sub CountData()
            Dim total As Integer = dgvData.Rows.Cast(Of DataGridViewRow)().Count(Function(r) Not r.IsNewRow)
            lblData.Text = $"Data: {total}"
        End Sub

        Private Sub btnsqlDate_Click(sender As Object, e As EventArgs)
            LoadSQLData()
        End Sub

        Private Sub btnSaveSqlChanges_Click(sender As Object, e As EventArgs)
            Try
                ' Hacer visible la barra de progreso y configurarla
                pgb.Visible = True
                pgb.Value = 0
                pgb.Maximum = dgvData.Rows.Count - 1  ' Establecer el máximo al número de filas del DataGridView

                lblProgress.Text = "Processing..." ' Mostrar el mensaje de progreso

                Using connection As SqlConnection = New SqlConnection(connectionString)
                    connection.Open()

                    ' 1. Verificar si la tabla existe, y si no, crearla
                    Dim checkTableQuery = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Skyserver_Updated' AND xtype = 'U') " & "BEGIN " & "CREATE TABLE dbo.Skyserver_Updated (" & "objid FLOAT, " & "ra FLOAT, " & "dec FLOAT, " & "u FLOAT, " & "g FLOAT, " & "r FLOAT, " & "i FLOAT, " & "z FLOAT, " & "run INT, " & "rerun INT, " & "camcol INT, " & "field INT, " & "specobjid FLOAT, " & "class VARCHAR(50), " & "redshift FLOAT, " & "plate INT, " & "mjd INT, " & "fiberid INT " & ") " & "END"

                    Using command As SqlCommand = New SqlCommand(checkTableQuery, connection)
                        command.ExecuteNonQuery()  ' Ejecutar la consulta para crear la tabla si no existe
                    End Using

                    ' 2. Crear la nueva DataTable con los datos modificados
                    Dim dataTable As DataTable = New DataTable()
                    dataTable.Columns.Add("objid", GetType(Double))
                    dataTable.Columns.Add("ra", GetType(Double))
                    dataTable.Columns.Add("dec", GetType(Double))
                    dataTable.Columns.Add("u", GetType(Double))
                    dataTable.Columns.Add("g", GetType(Double))
                    dataTable.Columns.Add("r", GetType(Double))
                    dataTable.Columns.Add("i", GetType(Double))
                    dataTable.Columns.Add("z", GetType(Double))
                    dataTable.Columns.Add("run", GetType(Integer))
                    dataTable.Columns.Add("rerun", GetType(Integer))
                    dataTable.Columns.Add("camcol", GetType(Integer))
                    dataTable.Columns.Add("field", GetType(Integer))
                    dataTable.Columns.Add("specobjid", GetType(Double))
                    dataTable.Columns.Add("class", GetType(String))
                    dataTable.Columns.Add("redshift", GetType(Double)) ' Usamos Double para redshift
                    dataTable.Columns.Add("plate", GetType(Integer))
                    dataTable.Columns.Add("mjd", GetType(Integer))
                    dataTable.Columns.Add("fiberid", GetType(Integer))

                    ' 3. Recorrer el DataGridView y agregar los datos modificados a la DataTable
                    For Each row As DataGridViewRow In dgvData.Rows
                        If Not row.IsNewRow Then
                            Dim dataRow As DataRow = dataTable.NewRow()

                            ' Validar y asignar cada columna numérica
                            dataRow("objid") = ValidateConvertDouble(row.Cells("objid").Value)
                            dataRow("ra") = ValidateConvertDouble(row.Cells("ra").Value)
                            dataRow("dec") = ValidateConvertDouble(row.Cells("dec").Value)
                            dataRow("u") = ValidateConvertDouble(row.Cells("u").Value)
                            dataRow("g") = ValidateConvertDouble(row.Cells("g").Value)
                            dataRow("r") = ValidateConvertDouble(row.Cells("r").Value)
                            dataRow("i") = ValidateConvertDouble(row.Cells("i").Value)
                            dataRow("z") = ValidateConvertDouble(row.Cells("z").Value)

                            ' Las columnas que no son numéricas no necesitan validación adicional
                            dataRow("run") = row.Cells("run").Value
                            dataRow("rerun") = row.Cells("rerun").Value
                            dataRow("camcol") = row.Cells("camcol").Value
                            dataRow("field") = row.Cells("field").Value
                            dataRow("specobjid") = ValidateConvertDouble(row.Cells("specobjid").Value)
                            dataRow("class") = row.Cells("class").Value
                            dataRow("redshift") = ValidateConvertDouble(row.Cells("redshift").Value)
                            dataRow("plate") = row.Cells("plate").Value
                            dataRow("mjd") = row.Cells("mjd").Value
                            dataRow("fiberid") = row.Cells("fiberid").Value

                            dataTable.Rows.Add(dataRow)
                        End If

                        ' Actualizar la barra de progreso y asegurarse de que no se pase del máximo
                        If pgb.Value < pgb.Maximum Then
                            pgb.Value += 1 ' Aumentar el valor
                        Else
                            pgb.Value = pgb.Maximum ' Asegurar que no se pase del máximo
                        End If
                    Next

                    ' 4. Usar SqlBulkCopy para insertar los datos en la nueva tabla "Skyserver_Updated"
                    Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(connection)
                        bulkCopy.DestinationTableName = "dbo.Skyserver_Updated"  ' Nombre de la nueva tabla
                        bulkCopy.WriteToServer(dataTable)  ' Insertar los datos
                    End Using

                    ' Mensaje de éxito
                    MessageBox.Show("Loaded correctly.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error creating the table or inserting the data: " & ex.Message)
            Finally
                ' Ocultar la barra de progreso al terminar
                pgb.Visible = False
                lblProgress.Visible = False
            End Try
        End Sub
        Private Function ValidateConvertDouble(value As Object) As Double
            Dim result As Double
            If value IsNot Nothing AndAlso Double.TryParse(value.ToString(), result) Then
                Return result
            End If
            Return 0.0 ' Valor predeterminado si no es un número válido
        End Function

        Private Sub btnEnviarArchivo_Click(sender As Object, e As EventArgs)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog With {
    ' Mostrar todos los tipos de archivos que has permitido para exportar
    .Filter = "CSV files (*.csv)|*.csv|TXT files (*.txt)|*.txt|JSON files (*.json)|*.json|XML files (*.xml)|*.xml|PDF files (*.pdf)|*.pdf",
    .Title = "Seleccionar archivo para enviar por correo"
}

            If openFileDialog.ShowDialog() <> DialogResult.OK Then Return

            Dim ruta = openFileDialog.FileName

            If Not File.Exists(ruta) Then
                MessageBox.Show("El archivo seleccionado no existe.")
                Return
            End If

            Try
                EnviarCorreo("rosalindacedillo2017@gmail.com", "Archivo Exportado", "Aquí está el archivo exportado.", ruta)
            Catch ex As Exception
                MessageBox.Show("Error al enviar el correo: " & ex.Message)
            End Try
        End Sub

    End Class
End Namespace
