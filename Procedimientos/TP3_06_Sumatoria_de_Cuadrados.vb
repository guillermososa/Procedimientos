Module TP3_06_Sumatoria_de_Cuadrados
    Private numero As Double
    Sub Main()
        EnteroPositivo()
        Console.WriteLine("La sumatoria de los cuadrados entre 1 y " &
                          numero & " es: " & Sumatoria(numero))
        Console.ReadKey()
    End Sub
    Private Sub EnteroPositivo()
        Do
            Console.Write("Ingrese un numero: ")
            numero = Console.ReadLine()
        Loop Until numero = Int(numero) And numero > 0
    End Sub
    Private Function Sumatoria(ByRef num)
        Dim i, acumulador As Integer
        For i = 1 To num
            acumulador += i ^ 2
        Next
        Return acumulador
    End Function
End Module