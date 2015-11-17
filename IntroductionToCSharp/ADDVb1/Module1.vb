Imports System

Module Module1

    Sub Main()

        Dim a As Integer = 10
        Dim b As Integer = 20
        Dim c As Integer

        c = Add(a, b)
        Console.WriteLine(c)

    End Sub

    Function Add(ByVal a As Integer, ByVal b As Integer)
        Return a + b
    End Function

End Module
