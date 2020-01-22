Module Module1
    Function totaltax(ByVal cost As Single) As Single
        Dim statetax, citytax As Single

        statetax = cost * 0.05 '5%
        citytax = cost * 0.015 '1.5%

        Return statetax + citytax
    End Function
End Module
