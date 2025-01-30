Public Class SplashScreenForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape1.Width += 1
            If RectangleShape1.Width >= 458 Then
                Timer1.[Stop]()
                LoginForm.Show()
                Me.Hide()
            End If
        Catch generaedExceptionName As Exception
            Return
        End Try
    End Sub
End Class
