Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1 As Double
        Dim var2 As Double
        Dim var3 As Double
        Dim var4 As Double
        Dim var5 As Double
        Dim var6 As Double
        Dim var7 As Double
        Dim var8 As Double
        Dim var9 As Double
        Dim var10 As Double
        Dim var11 As Double
        Dim var12 As Double
        Dim var13 As Double
        Dim var14 As Double
        Dim var15 As Double
        Dim var16 As Double
        Dim var17 As Double
        Dim var18 As Double

        Dim op1 As Double
        Dim op2 As Double
        Dim op3 As Double
        Dim op4 As Double
        Dim op5 As Double
        Dim op6 As Double
        Dim op7 As Double
        Dim op8 As Double
        Dim op9 As Double

        var1 = CDbl(TextBox1.Text)
        var2 = CDbl(TextBox10.Text)
        op1 = var1 + var2
        TextBox27.Text = op1
        var3 = CDbl(TextBox2.Text)
        var4 = CDbl(TextBox11.Text)
        op2 = var3 + var4
        TextBox26.Text = op2
        var5 = CDbl(TextBox3.Text)
        var6 = CDbl(TextBox12.Text)
        op3 = var5 + var6
        TextBox25.Text = op3
        var7 = CDbl(TextBox4.Text)
        var8 = CDbl(TextBox13.Text)
        op4 = var7 + var8
        TextBox24.Text = op4
        var9 = CDbl(TextBox5.Text)
        var10 = CDbl(TextBox14.Text)
        op5 = var9 + var10
        TextBox23.Text = op5
        var11 = CDbl(TextBox6.Text)
        var12 = CDbl(TextBox15.Text)
        op6 = var11 + var12
        TextBox22.Text = op6
        var13 = CDbl(TextBox7.Text)
        var14 = CDbl(TextBox16.Text)
        op7 = var13 + var14
        TextBox21.Text = op7
        var15 = CDbl(TextBox8.Text)
        var16 = CDbl(TextBox17.Text)
        op8 = var15 + var16
        TextBox20.Text = op8
        var17 = CDbl(TextBox9.Text)
        var18 = CDbl(TextBox18.Text)
        op9 = var17 + var18
        TextBox19.Text = op9


        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        TextBox14.Enabled = False
        TextBox15.Enabled = False
        TextBox16.Enabled = False
        TextBox17.Enabled = False
        TextBox18.Enabled = False



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True
        TextBox14.Enabled = True
        TextBox15.Enabled = True
        TextBox16.Enabled = True
        TextBox17.Enabled = True
        TextBox18.Enabled = True

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Parent = PictureBox1
        Label5.BackColor = Color.Transparent



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.Parent = PictureBox1
        Label6.BackColor = Color.Transparent
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Parent = PictureBox1
        Label4.BackColor = Color.Transparent
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Label8.Parent = PictureBox1
        Label8.BackColor = Color.Transparent
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Parent = PictureBox1
        Label7.BackColor = Color.Transparent
    End Sub
End Class