Module TP3_06_Sumatoria_de_Cuadrados
    Sub Main()
        Dim numero As Double
        numero = Positivo("Ingrese un numero: ")
        Console.WriteLine("La sumatoria de los cuadrados entre 1 y " & numero & " es: " & Sumatoria(numero))
        Console.ReadKey()
    End Sub
    Private Function Positivo(mensaje As String) As Double
        Dim ingreso As Double
        Do
            Console.Write(mensaje)
            ingreso = Console.ReadLine()
        Loop While ingreso < 0
        Return ingreso
    End Function
    Private Function Sumatoria(ByRef num)
        Dim acumulador As Integer
        Dim i As Integer
        For i = 1 To num
            acumulador += i ^ 2
        Next
        Return acumulador
    End Function
End Module