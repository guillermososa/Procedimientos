Module TP3_03_Potencia
    Sub Main()
        Dim num As Integer
        Console.Write("Ingrese un valor: ")
        num = Console.ReadLine()
        Console.WriteLine()
        For i = 2 To 6
            Console.WriteLine("La potencia de {0} elevado a la {1} es: {2}.",
                              num, i, Potencia(num, i))
        Next
        Console.ReadKey()
    End Sub
    Private Function Potencia(base As Integer, exponente As Integer) As Integer
        Return base ^ exponente
    End Function
End Module