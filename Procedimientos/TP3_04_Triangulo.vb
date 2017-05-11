Module TP3_04_Triangulo
    Sub Main()
        Dim a As Double
        Dim b As Double
        a = Positivo("Ingrese lado A: ")
        b = Positivo("Ingrese lado B: ")
        Console.WriteLine("Hipotenusa: " & Hipotenusa(a, b))
        Console.ReadKey()
    End Sub
    Private Function Positivo(mensaje As String) As Double
        Dim ingreso As Double
        Do
            Console.Write(mensaje)
            ingreso = Console.ReadLine()
        Loop Until ingreso > 0 And ingreso = Int(ingreso)
        Return ingreso
    End Function
    Private Function Hipotenusa(a As Integer, b As Integer) As Double
        Return Math.Sqrt(a ^ 2 + b ^ 2)
    End Function
End Module