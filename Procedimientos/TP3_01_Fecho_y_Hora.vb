Module TP3_01_Fecho_y_Hora
    Sub Main()
        ImprimirFechaActual()
        Console.WriteLine("Hora Actual: " & HoraActual())
        Console.ReadKey()
    End Sub
    Sub ImprimirFechaActual()
        Console.WriteLine("Mostrar Fecha y Hora Actual" & vbNewLine)
        Console.WriteLine("Fecha Actual: " & Date.Today)
    End Sub
    Private Function HoraActual() As String
        Return TimeOfDay
    End Function
End Module