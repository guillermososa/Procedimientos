Module TP3_01_Fecho_y_Hora
    'Crear un módulo que imprima la fecha y hora actual con sus respectivas leyendas según las
    'siguientes condiciones :  
    ' Utilizar una sub para imprimir la fecha actual.
    ' Utilizar una function para obtener la hora actual.
    ' Llamar a los métodos desde el método Main.
    Sub Main()
        ImprimirFechaActual()
        Console.WriteLine("Hora Actual: " & HoraActual())
        Console.ReadKey()
    End Sub
    Sub ImprimirFechaActual()
        Console.WriteLine("Mostrar Fecha y Hora Actual")
        Console.WriteLine()
        Console.WriteLine("Fecha Actual: " & Date.Today)
    End Sub
    Private Function HoraActual() As String
        Return TimeOfDay
    End Function
End Module