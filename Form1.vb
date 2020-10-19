Public Class Form1
    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        If Not pn_menu.Visible Then
            Guna2Transition1.ShowSync(pn_menu)
        Else
            Guna2Transition1.HideSync(pn_menu)
        End If
    End Sub
End Class
