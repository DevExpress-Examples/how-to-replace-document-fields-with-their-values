Imports System
Imports System.Net
Imports System.Windows.Forms

Namespace RichEditFieldsToValues

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol Or SecurityProtocolType.Tls12
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
