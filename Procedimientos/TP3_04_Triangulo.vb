Module TP3_04_Triangulo
    Sub Main()
        Dim ladoa As Double
        Dim ladob As Double
        Do
            Console.Write("Ingrese lado A: ")
            ladoa = Console.ReadLine()
        Loop Until EnterosPositivos(ladoa)
        Do
            Console.Write("Ingrese lado B: ")
            ladob = Console.ReadLine()
        Loop Until EnterosPositivos(ladoa)
        Console.WriteLine("Hipotenusa: " & Hipotenusa(ladoa, ladob))
        Console.ReadKey()
    End Sub
    Private Function EnterosPositivos(ingreso As Double) As Double
        If ingreso = Int(ingreso) And ingreso > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function Hipotenusa(a As Integer, b As Integer) As Double
        Return Math.Sqrt(a ^ 2 + b ^ 2)
    End Function
End Module