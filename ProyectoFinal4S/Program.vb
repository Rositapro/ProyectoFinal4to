Namespace ProyectoFinal4S
    Friend Module Program
        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            ' To customize application configuration such as set high DPI settings or default font,
            ' see https://aka.ms/applicationconfiguration.
            ProyectoFinal4S.ApplicationConfiguration.Initialize()
            Call System.Windows.Forms.Application.Run(New FrmMenu())
        End Sub
    End Module
End Namespace
