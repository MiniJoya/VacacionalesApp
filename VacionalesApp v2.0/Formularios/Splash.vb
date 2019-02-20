Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        lblPorcentaje.Text = "0%"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            frmLoginNew.Show()
        End If
        lblPorcentaje.Text = ProgressBar1.Value & ("%")
    End Sub
End Class