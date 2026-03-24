Imports System.Windows.Forms

Module Program
    <STAThread()>
    Sub Main()
        ApplicationConfiguration.Initialize()
        Application.Run(New LoginForm())
    End Sub
End Module

