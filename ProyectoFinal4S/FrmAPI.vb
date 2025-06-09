
Namespace ProyectoFinal4S
    Public Partial Class FrmAPI
        Inherits System.Windows.Forms.Form
        Private Const api As String = "https://api.nasa.gov/planetary/apod"
        Private Const key As String = "dlI71b7WG1efSkePYdr6zw61QSrjIMqqDQDn7GTQ"
                ''' Cannot convert FieldDeclarationSyntax, System.InvalidCastException: No se puede convertir un objeto de tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' al tipo 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         private readonly System.Net.Http.HttpClient _httpClient = new();
''' 
''' 

        Public Sub New()
            InitializeComponent()
            cbMonth.Items.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
            cbMonth.SelectedIndex = 0

            AddHandler dgvData.CellContentClick, AddressOf dgvData_CellContentClick

            ' Convertir columna "url" a tipo link
        End Sub

                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not System.Windows.Forms.DataGridViewLinkColumn.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private async void btnSearch_Click(object sender, System.EventArgs e)
'''         {
'''             if (this.cbMonth.SelectedIndex < 0)
'''             {
'''                 System.Windows.Forms.MessageBox.Show("Selecciona un mes.");
'''                 return;
'''             }
''' 
'''             int selectedMonth = this.cbMonth.SelectedIndex + 1;
'''             int year = System.DateTime.Now.Year;
''' 
'''             System.DateTime start = new System.DateTime(year, selectedMonth, 1);
'''             System.DateTime end = start.AddMonths((System.Int32)(1)).AddDays(-1);
''' 
'''             string startDate = start.ToString("yyyy-MM-dd");
'''             string endDate = end.ToString("yyyy-MM-dd");
''' 
'''             string url = $"{ProyectoFinal4S.FrmAPI.api}?api_key={ProyectoFinal4S.FrmAPI.key}&start_date={startDate}&end_date={endDate}";
''' 
'''             try
'''             {
'''                 string json = await this._httpClient.GetStringAsync(url);
'''                 var result = System.Text.Json.JsonSerializer.Deserialize<System.Collections.Generic.List<ProyectoFinal4S.FrmAPI.ApodResponse>>(json);
''' 
'''                 if (result != null)
'''                 {
'''                     this.dgvData.DataSource = result;
'''                     this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
'''                     this.dgvData.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
'''                     this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
''' 
'''                     // Convertir columna "url" a tipo link
'''                     if (this.dgvData.Columns["url"] is not System.Windows.Forms.DataGridViewLinkColumn)
'''                     {
'''                         int colIndex = this.dgvData.Columns[(System.String)("url")].Index;
'''                         var linkCol = new System.Windows.Forms.DataGridViewLinkColumn
'''                         {
'''                             Name = "url",
'''                             HeaderText = "Imagen",
'''                             DataPropertyName = "url",
'''                             UseColumnTextForLinkValue = false,
'''                             LinkBehavior = System.Windows.Forms.LinkBehavior.SystemDefault
'''                         };
''' 
'''                         this.dgvData.Columns.Remove("url");
'''                         this.dgvData.Columns.Insert(colIndex, linkCol);
'''                     }
'''                 }
'''                 else
'''                 {
'''                     System.Windows.Forms.MessageBox.Show("No se encontraron datos para ese mes.");
'''                 }
'''             }
'''             catch (System.Exception ex)
'''             {
'''                 System.Windows.Forms.MessageBox.Show("Error al obtener los datos: " + ex.Message);
'''             }
'''         }
''' 
''' 

        Private Sub dgvData_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If e.RowIndex >= 0 AndAlso Equals(dgvData.Columns(e.ColumnIndex).Name, "url") Then
                Dim cellValue = dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
                If Not String.IsNullOrEmpty(cellValue) Then
                    Try
                        Process.Start(New ProcessStartInfo With {
    .FileName = cellValue,
    .UseShellExecute = True
})
                    Catch ex As Exception
                        System.Windows.Forms.MessageBox.Show("No se pudo abrir el enlace: " & ex.Message)
                    End Try
                End If
            End If
        End Sub

        Public Class ApodResponse
            Public Property title As String
            Public Property [date] As String
            Public Property explanation As String
            Public Property url As String
            Public Property media_type As String
        End Class

        Private Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub btnGoBack_Click(sender As Object, e As EventArgs)
            Dim menu As FrmMenu = New FrmMenu()
            menu.Show()
            Close()
        End Sub
    End Class
End Namespace
