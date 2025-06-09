Imports System
Imports System.Windows.Forms

Namespace ProyectoFinal4S
    Public Partial Class FrmMenu
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnAPI_Click(sender As Object, e As EventArgs)
            Dim form As Form = New FrmAPI()
            form.Show()
            Hide()
        End Sub

        Private Sub btnDataSet_Click(sender As Object, e As EventArgs)
            Dim form As Form = New FrmDataSet()
            form.Show()
            Hide()
        End Sub
    End Class
End Namespace
