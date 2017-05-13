Module TP3_09_Superficie
    Sub Main()
        Dim valor1, valor2, valor3 As Double
        Dim op As UShort
        Console.Write("Seleccione una opcion para calcular superficio(1=Cuadrado, 2=Rectangulo, 3=Trapecio): ")
        op = Console.ReadLine()
        If op = 1 Or op = 2 Then
            Console.Write("Ingrese lado o base: ")
            valor1 = Console.ReadLine()
            Console.Write("Ingrese lado o altura: ")
            valor2 = Console.ReadLine()
            Mostrar("El area o superficie es: " & Area(valor1, valor2))
        End If
        If op = 3 Then
            Console.Write("Ingrese base mayor: ")
            valor1 = Console.ReadLine()
            Console.Write("Ingrese base menor: ")
            valor2 = Console.ReadLine()
            Console.Write("Ingrese altura: ")
            valor3 = Console.ReadLine()
            Mostrar("El area o superficie es: " & Area(valor1, valor2, valor3))
        End If
        Console.ReadKey()
    End Sub
    Private Function Area(b As Double, h As Double) As Double
        Return b * h
    End Function
    Private Function Area(bmay As Double, bmen As Double, h As Double) As Double
        Return (bmay + bmen) / 2 * h
    End Function
    Private Sub Mostrar(mensaje As String)
        Console.WriteLine(mensaje)
    End Sub
End Module