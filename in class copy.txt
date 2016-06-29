Public Class ArraySample
    '31 length array
    Dim intData(30) As Integer
    Dim strData(20) As String

    'initialize your array
    Dim intdata1() As Integer = {12, 16, 20, 28}
    Dim names() As String = {"Tom", "Ken", "John"}

    Dim miscData() As Object = {"Hello", 12, 16.0, "A"}
    Public Sub OutputArray()
        Dim strArr As String = String.Empty

        For index = 0 To names.Length - 1

            strArr += String.Format("Element{0} = {1}", index, names(index)) & Environment.NewLine
        Next
        MessageBox.Show(strArr)

    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objSample As ArraySample = New ArraySample()
        objSample.OutputArray()

    End Sub

    Public Sub ReverseArray()

        Array.Sort(names)
        OutputArray()
    End Sub
End Class
