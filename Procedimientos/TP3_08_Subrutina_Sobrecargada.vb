Module TP3_07_Funcion_Sobrecargada
    Enum operaciones
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub Main()
        Dim num1 As Integer = 24
        Dim num2 As Integer = 2
        Dim num3 As Integer = 3
        Dim num4 As Integer = 4
        'operaciones con 2 argumentos
        Mostrar("Suma de dos numeros: " & Calcular(operaciones.suma, num1, num2))
        Mostrar("Resta de dos numeros: " & Calcular(operaciones.resta, num1, num2))
        Mostrar("Multiplicacion de dos numeros: " & Calcular(operaciones.multiplicacion, num1, num2))
        Mostrar("Division de dos numeros: " & Calcular(operaciones.division, num1, num2))
        Mostrar("")
        'operaciones con 3 argumentos
        Mostrar("Suma de tres numeros: " & Calcular(operaciones.suma, num1, num2, num3))
        Mostrar("Resta de tres numeros: " & Calcular(operaciones.resta, num1, num2, num3))
        Mostrar("Multiplicacion de tres numeros: " & Calcular(operaciones.multiplicacion, num1, num2, num3))
        Mostrar("Division de tres numeros: " & Calcular(operaciones.division, num1, num2, num3))
        Mostrar("")
        'operaciones con 4 argumentos
        Mostrar("Suma de cuatro numeros: " & Calcular(operaciones.suma, num1, num2, num3, num4))
        Mostrar("Resta de cuatro numeros: " & Calcular(operaciones.resta, num1, num2, num3, num4))
        Mostrar("Multiplicacion de cuatro numeros: " & Calcular(operaciones.multiplicacion, num1, num2, num3, num4))
        Mostrar("Division de cuatro numeros: " & Calcular(operaciones.division, num1, num2, num3, num4))
        Console.ReadKey()
    End Sub
    Private Function Calcular(op As Integer, num1 As Integer, num2 As Integer) As Integer
        Select Case op
            Case operaciones.suma
                Return num1 + num2
            Case operaciones.resta
                Return num1 - num2
            Case operaciones.multiplicacion
                Return num1 * num2
            Case Else
                Return num1 / num2
        End Select
    End Function
    Private Function Calcular(op As Integer, num1 As Integer, num2 As Integer, num3 As Integer) As Integer
        Return Calcular(op, Calcular(op, num1, num2), num3)
    End Function
    Private Function Calcular(op As Integer, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Integer
        Return Calcular(op, Calcular(op, Calcular(op, num1, num2), num3), num4)
    End Function
    Private Sub Mostrar(mensaje As String)
        Console.WriteLine(mensaje)
    End Sub
End Module