Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This application makes use of TSWizard, a wizard framework for .NET.
        'It was actually created in C# for .NET 2.0 but currently works as a dll in this app.
        'Documentation can be found at the following address:
        'http://www.codeproject.com/Articles/2911/TSWizard-a-wizard-framework-for-NET
        'TSWizard is libre (free), open source software;
        'proper licensing information can be found in the file titled "TSWizard-License.txt"
        'Windows does not provide an easy way to center a user control within a form or another user control.
        'Because of this, CenterMessagebox, more libre (free) open source software, is used to do so;
        'proper licensing information can be found in the file titled "CenterMessagebox-License.txt"

        'If you haven't already read the file titled "Future-Developer-README.txt," then you should do so
        'if you are indeed a developer in the future (Today's date: 08/18/2014) wanting to maintain this software.

        'Create an instance of the PCW class and show it
        Dim wizard As PCW = New PCW
        wizard.ShowDialog()
    End Sub
End Class