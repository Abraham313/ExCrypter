Module asmchnger
    Dim Title As String
    Dim Description As String
    Dim Company As String
    Dim Product As String
    Dim Copyright As String
    Dim Trademark As String
    Dim v1 As String
    Dim v2 As String
    Dim v3 As String
    Dim v4 As String
    Public info(10) As String
    Public Function ReadAssembly(ByVal Filepath As String)

        Dim f As FileVersionInfo = FileVersionInfo.GetVersionInfo(Filepath)
        Title = f.InternalName
        Description = f.FileDescription
        Company = f.CompanyName
        Product = f.ProductName
        Copyright = f.LegalCopyright
        Trademark = f.LegalTrademarks
        Dim version As String()
        If f.FileVersion.Contains(",") Then
            version = f.FileVersion.Split(","c)
        Else
            version = f.FileVersion.Split("."c)
        End If
        Try
            v1 = version(0)
            v2 = version(1)
            v3 = version(2)
            v4 = version(3)
        Catch ex As Exception

        End Try
        info(1) = Title : info(2) = Description : info(3) = Company : info(4) = Product : info(5) = Copyright : info(6) = Trademark : info(7) = v1 : info(8) = v2 : info(9) = v3 : info(10) = v4
        Return info
    End Function
End Module
