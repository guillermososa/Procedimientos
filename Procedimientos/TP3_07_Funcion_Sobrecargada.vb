Module TP3_07_Funcion_Sobrecargada
    Enum operaciones As UShort
        suma
        resta
        multiplicacion
        division
    End Enum
    Private operacion As operaciones
    Sub Main()
        Dim num1 As UShort = 24
        Dim num2 As UShort = 2
        Dim num3 As UShort = 3
        Dim num4 As UShort = 4
        'Operaciones con 2 argumentos
        Mostrar("Suma de dos numeros: " & Calcular(operacion.suma, num1, num2))
        Mostrar("Resta de dos numeros: " & Calcular(operacion.resta, num1, num2))
        Mostrar("Multiplicacion de dos numeros: " & Calcular(operacion.multiplicacion, num1, num2))
        Mostrar("Division de dos numeros: " & Calcular(operacion.division, num1, num2))
        Mostrar("")
        'Operaciones con 3 argumentos
        Mostrar("Suma de tres numeros: " & Calcular(operacion.suma, num1, num2, num3))
        Mostrar("Resta de tres numeros: " & Calcular(operacion.resta, num1, num2, num3))
        Mostrar("Multiplicacion de tres numeros: " & Calcular(operacion.multiplicacion, num1, num2, num3))
        Mostrar("Division de tres numeros: " & Calcular(operacion.division, num1, num2, num3))
        Mostrar("")
        'Operaciones con 4 argumentos
        Mostrar("Suma de cuatro numeros: " & Calcular(operacion.suma, num1, num2, num3, num4))
        Mostrar("Resta de cuatro numeros: " & Calcular(operacion.resta, num1, num2, num3, num4))
        Mostrar("Multiplicacion de cuatro numeros: " & Calcular(operacion.multiplicacion, num1, num2, num3, num4))
        Mostrar("Division de cuatro numeros: " & Calcular(operacion.division, num1, num2, num3, num4))
        Mostrar("")
        Console.ReadKey()
    End Sub
    Private Function Calcular(op As UShort, num1 As UShort, num2 As UShort) As Integer
        Select Case op
            Case operacion.suma
                Return num1 + num2
            Case operacion.resta
                Return num1 - num2
            Case operacion.multiplicacion
                Return num1 * num2
            Case operacion.division
                Return num1 / num2
            Case Else
                Return 0
        End Select
    End Function
    Private Function Calcular(op As UShort, num1 As UShort, num2 As UShort, num3 As UShort) As Integer
        Select Case op
            Case operacion.suma
                Return num1 + num2 + num3
            Case operacion.resta
                Return num1 - num2 - num3
            Case operacion.multiplicacion
                Return num1 * num2 * num3
            Case operacion.division
                Return num1 / num2 / num3
            Case Else
                Return 0
        End Select
    End Function
    Private Function Calcular(op As UShort, num1 As UShort, num2 As UShort, num3 As UShort, num4 As UShort) As Integer
        Select Case op
            Case operacion.suma
                Return num1 + num2 + num3 + num4
            Case operacion.resta
                Return num1 - num2 - num3 - num4
            Case operacion.multiplicacion
                Return num1 * num2 * num3 * num4
            Case operacion.division
                Return num1 / num2 / num3 / num4
            Case Else
                Return 0
        End Select
    End Function
    Private Sub Mostrar(mensaje As String)
        Console.WriteLine(mensaje)
    End Sub
End Module