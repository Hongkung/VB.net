Module Mtest


    'short type public 변수 선언
    Public wins As Short
    Public spins As Short


    Function hitRate(ByVal hits As Short, ByVal tries As Short) As String
        Dim percent As Single
        percent = hits / tries


        Return Format(percent, "0.0$")
    End Function
End Module
