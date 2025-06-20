Public Class Form1
    Dim a As Decimal = 0
    Dim b As Decimal = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = a
        a = a + 1
        Select Case a
            Case 0 To 3
                PictureBox1.Visible = True
            Case 3 To 4.5
                PictureBox1.Visible = False
                PictureBox2.Visible = True
            Case 4.5 To 7.5
                PictureBox2.Visible = False
                PictureBox3.Visible = True
            Case 7.5 To 9.5
                PictureBox3.Visible = False
                PictureBox4.Visible = True
            Case Else
                a = 0
                PictureBox4.Visible = False
                PictureBox1.Visible = True
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
        PictureBox5.Visible = True
        a = 0
        b = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Start()
        Timer1.Stop()
        a = 0
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        b = b + 1
        Label2.Text = b
        Select b
            Case 0 To 1.5
                PictureBox5.Visible = True
            Case 1.5 To 3
                PictureBox5.Visible = False
                PictureBox4.Visible = True
                b = 0
        End Select
    End Sub
End Class
