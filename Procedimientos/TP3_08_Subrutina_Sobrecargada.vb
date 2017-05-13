Module TP3_08_Subrutina_Sobrecargada
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
        Resultado(operacion.suma, num1, num2)
        Resultado(operacion.resta, num1, num2)
        Resultado(operacion.multiplicacion, num1, num2)
        Resultado(operacion.division, num1, num2)
        Mostrar("")
        'Operaciones con 3 argumentos
        Resultado(operacion.suma, num1, num2, num3)
        Resultado(operacion.resta, num1, num2, num3)
        Resultado(operacion.multiplicacion, num1, num2, num3)
        Resultado(operacion.division, num1, num2, num3)
        Mostrar("")
        'Operaciones con 4 argumentos
        Resultado(operacion.suma, num1, num2, num3, num4)
        Resultado(operacion.resta, num1, num2, num3, num4)
        Resultado(operacion.multiplicacion, num1, num2, num3, num4)
        Resultado(operacion.division, num1, num2, num3, num4)
        Mostrar("")
        Console.ReadKey()
    End Sub
    Private Sub Resultado(op As UShort, num1 As UShort, num2 As UShort)
        Select Case op
            Case operacion.suma
                Mostrar("Suma de dos numeros: " & Calcular(operacion.suma, num1, num2))
            Case operacion.resta
                Mostrar("Resta de dos numeros: " & Calcular(operacion.resta, num1, num2))
            Case operacion.multiplicacion
                Mostrar("Multiplicacion de dos numeros: " & Calcular(operacion.multiplicacion, num1, num2))
            Case operacion.division
                Mostrar("Division de dos numeros: " & Calcular(operacion.division, num1, num2))
            Case Else
                Mostrar("")
        End Select
    End Sub
    Private Sub Resultado(op As UShort, num1 As UShort, num2 As UShort, num3 As UShort)
        Select Case op
            Case operacion.suma
                Mostrar("Suma de tres numeros: " & Calcular(operacion.suma, num1, num2, num3))
            Case operacion.resta
                Mostrar("Resta de tres numeros: " & Calcular(operacion.resta, num1, num2, num3))
            Case operacion.multiplicacion
                Mostrar("Multiplicacion de tres numeros: " & Calcular(operacion.multiplicacion, num1, num2, num3))
            Case operacion.division
                Mostrar("Division de tres numeros: " & Calcular(operacion.division, num1, num2, num3))
            Case Else
                Mostrar("")
        End Select
    End Sub
    Private Sub Resultado(op As UShort, num1 As UShort, num2 As UShort, num3 As UShort, num4 As UShort)
        Select Case op
            Case operacion.suma
                Mostrar("Suma de cuatro numeros: " & Calcular(operacion.suma, num1, num2, num3, num4))
            Case operacion.resta
                Mostrar("Resta de cuatro numeros: " & Calcular(operacion.resta, num1, num2, num3, num4))
            Case operacion.multiplicacion
                Mostrar("Multiplicacion de cuatro numeros: " & Calcular(operacion.multiplicacion, num1, num2, num3, num4))
            Case operacion.division
                Mostrar("Division de cuatro numeros: " & Calcular(operacion.division, num1, num2, num3, num4))
            Case Else
                Mostrar("")
        End Select
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