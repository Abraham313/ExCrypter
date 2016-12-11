Imports System.CodeDom.Compiler
Imports System.IO

Module Module1
    Public Function asminfo(title As String, desc As String, comp As String, prod As String, copy As String, trade As String, vers As String)
        If File.Exists(Application.StartupPath & "\res.exe") Then
            File.Delete(Application.StartupPath & "\res.exe")
        End If
        If File.Exists(Application.StartupPath & "\assemblychange.res") Then
            File.Delete(Application.StartupPath & "\assemblychange.res")
        End If
        System.IO.File.WriteAllBytes(Application.StartupPath & "\res.exe", My.Resources.Res)
        Dim source As String = My.Resources.String1
        If File.Exists(Application.StartupPath & "\assemblychange.exe") Then
            File.Delete(Application.StartupPath & "\assemblychange.exe")
        End If
        Dim Version = New Collections.Generic.Dictionary(Of String, String) : Version.Add("CompilerVersion", "v2.0")
        Dim Compiler As VBCodeProvider = New VBCodeProvider(Version)
        Dim cResults As CompilerResults
        Dim Settings As New CompilerParameters()
        With Settings
            .GenerateExecutable = True
            .OutputAssembly = Application.StartupPath & "\assemblychange.exe"
            .CompilerOptions = "/target:winexe"
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .MainClass = "X"
        End With
        source = source.Replace("*Title*", title)
        source = source.Replace("*Description*", desc)
        source = source.Replace("*Company*", comp)
        source = source.Replace("*Product*", prod)
        source = source.Replace("*Copyright*", copy)
        source = source.Replace("*Trademark*", trade)
        source = source.Replace("*version*", vers) 'NumericUpDown1.Value.ToString & "." & NumericUpDown2.Value.ToString & "." & NumericUpDown3.Value.ToString & "." & NumericUpDown4.Value.ToString)
        source = source.Replace("*fversion*", vers)
        cResults = Compiler.CompileAssemblyFromSource(Settings, source)
        If cResults.Errors.Count > 0 Then
            For Each CompilerError In cResults.Errors
                MessageBox.Show("Error: " & CompilerError.ErrorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Next
            If File.Exists(Application.StartupPath & "\res.exe") = True Then
                File.Delete(Application.StartupPath & "\res.exe")
            End If
            If File.Exists(Application.StartupPath & "\res.log") = True Then
                File.Delete(Application.StartupPath & "\res.log")
            End If
            If File.Exists(Application.StartupPath & "\res.ini") = True Then
                File.Delete(Application.StartupPath & "\res.ini")
            End If
            If File.Exists(Application.StartupPath & "\assemblychange.exe") Then
                File.Delete(Application.StartupPath & "\assemblychange.exe")
            End If
            If File.Exists(Application.StartupPath & "\assemblychange.res") Then
                File.Delete(Application.StartupPath & "\assemblychange.res")
            End If
            MessageBox.Show("An error occurred. The assembly was not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        Dim otherfile As String = Application.StartupPath & "\assemblychange.exe"
        Dim resfile As String = Application.StartupPath & "\assemblychange.res"
        Dim mainfile As String = Form1.patth
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -extract " & otherfile & "," & resfile & ",VERSIONINFO,,")
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -delete " & mainfile & "," & System.AppDomain.CurrentDomain.BaseDirectory() + "res.exe" & ",VERSIONINFO,,")
        Shell(System.AppDomain.CurrentDomain.BaseDirectory() & "res.exe -addoverwrite " & mainfile & "," & mainfile & "," & resfile & ",VERSIONINFO,1,")
        Threading.Thread.Sleep(200)
        If File.Exists(Application.StartupPath & "\assemblychange.exe") Then
            File.Delete(Application.StartupPath & "\assemblychange.exe")
        End If
        If File.Exists(Application.StartupPath & "\assemblychange.res") Then
            File.Delete(Application.StartupPath & "\assemblychange.res")
        End If
        If File.Exists(Application.StartupPath & "\res.exe") = True Then
            File.Delete(Application.StartupPath & "\res.exe")
        End If
        If File.Exists(Application.StartupPath & "\res.log") = True Then
            File.Delete(Application.StartupPath & "\res.log")
        End If
        If File.Exists(Application.StartupPath & "\res.ini") = True Then
            File.Delete(Application.StartupPath & "\res.ini")
        End If


    End Function
End Module
