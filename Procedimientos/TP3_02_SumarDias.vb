﻿Module TP3_02_SumarDias
    Sub Main()
        Dim fecha As Date
        Dim dias As UShort
        Console.WriteLine("Sumar días a la fecha" & vbNewLine)
        Console.Write("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias: ")
        dias = Console.ReadLine()
        Console.WriteLine("Fecha Resultado: " & SumarDias(fecha, dias))
        Console.ReadKey()
    End Sub
    Sub ImprimirFechaActual()
        Console.WriteLine("Fecha Actual: " & Date.Today)
    End Sub
    Private Function SumarDias(fecha As Date, dias As Integer) As Date
        Return fecha.AddDays(dias)
    End Function
End Module