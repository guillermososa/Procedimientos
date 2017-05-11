Module TP3_02_SumarDias
    'Crear una función que reciba una fecha y un entero que representa una cantidad de días a sumar
    'a la fecha. Desde el módulo principal ingresar una fecha y la cantidad de días e invocar a esta
    'función pasándole los parámetros: fecha actual y días, mostrar el valor obtenido.
    Sub Main()
        Dim fecha As Date
        Dim dias As UShort
        Console.WriteLine("Sumar días a la fecha")
        Console.WriteLine()
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