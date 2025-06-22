Public Class Form1
    Dim a As Integer
    Dim b As Integer = 0
    Dim c As Integer
    Dim d As Boolean = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        a = Int(Rnd() * 50)
        Label1.Text = "historial : "
        ProgressBar1.Maximum = 10
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        c = TextBox1.Text
        b = b + 1
        ProgressBar1.Value = b
        Label3.Text = "intentos : " & b
        Label1.Text = Label1.Text & "-" & c & "-"

        If b = 10 Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            Label3.Text = "intentos : " & b & "limite alcanzado"
            PictureBox2.Visible = True
            Label4.Text = "el numero era : " & a
        ElseIf a = c Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            Label3.Text = "intentos : " & b & "adivino"
            PictureBox1.Visible = True

        End If


        If a = c Then
            Label2.Text = "adivinaste el numero"
        ElseIf a > c Then
            Label2.Text = "el numero que buscas es mayor"
        ElseIf a < c Then
            Label2.Text = "el numero que buscas es menor"
        End If

    End Sub

End Class
