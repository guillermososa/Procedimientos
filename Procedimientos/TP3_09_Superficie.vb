Module TP3_09_Superficie
    Enum opcion
        Cuadrado = 1
        Rectangulo = 2
        Trapecio = 3
    End Enum
    Sub Main()
        Dim valor1, valor2, valor3 As Double
        Dim op As opcion
        Mostrar("Seleccione una opcion para calcular superficie(1=Cuadrado, 2=Rectangulo, 3=Trapecio): ")
        op = Console.ReadLine()
        If op = 1 Or op = 2 Then
            Mostrar("Ingrese lado o base: ")
            valor1 = Console.ReadLine()
            Mostrar("Ingrese lado o altura: ")
            valor2 = Console.ReadLine()
            Mostrar("El area o superficie es: " & Area(valor1, valor2))
        Else
            Mostrar("Ingrese base mayor: ")
            valor1 = Console.ReadLine()
            Mostrar("Ingrese base menor: ")
            valor2 = Console.ReadLine()
            Mostrar("Ingrese altura: ")
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
