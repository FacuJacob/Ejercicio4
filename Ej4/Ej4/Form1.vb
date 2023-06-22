Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim matriz(10, 8) As Integer
        Dim vector(10) As Integer
        For f = 1 To 10
            For c = 1 To 8
                matriz(f, c) = InputBox("Ingrese los valores de la matriz", "Matriz")
            Next
        Next
        For f = 1 To 10
            vector(f) = matriz(f, 1)
            For c = 1 To 8
                If vector(f) > matriz(f, c) Then
                    vector(f) = matriz(f, c)
                End If
            Next
        Next



        grdMatriz.Columns.Clear()
        For j = 1 To 8
            grdMatriz.Columns.Add("", "")
            grdMatriz.Columns(j - 1).Width = 35
        Next
        grdMatriz.Rows.Add(9)

        lstVector.Items.Clear()


        For f = 1 To 10
            For c = 1 To 8
                grdMatriz.Item(c - 1, f - 1).Value = matriz(f, c)
            Next
        Next
        For j = 1 To 10
            lstVector.Items.Add(vector(j))
        Next
    End Sub
End Class
