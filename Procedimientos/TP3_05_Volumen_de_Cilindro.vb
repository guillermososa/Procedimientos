Module TP3_05_Volumen_de_Cilindro
    Private radio As Double
    Private altura As Double
    Sub Main()
        Validar()
        Console.WriteLine("El volumen del cilindro es: " & VolumenCilindro(radio, altura))
        Console.ReadKey()
    End Sub
    Private Sub Validar()
        Do
            Console.Write("Ingrese radio de la base: ")
            radio = Console.ReadLine()
        Loop Until radio > 0
        Do
            Console.Write("Ingrese altura del cilindro: ")
            altura = Console.ReadLine()
        Loop Until altura > 0
    End Sub
    Private Function VolumenCilindro(r As Double, h As Double) As Double
        Return Math.PI * r ^ 2 * h
    End Function
End Module