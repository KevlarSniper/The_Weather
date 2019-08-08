Imports MaterialSkin
Public Class Form1
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        PictureBox3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PictureBox1.Visible = False
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)


    End Sub

End Class


