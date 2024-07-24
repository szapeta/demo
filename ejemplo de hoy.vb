Module Module1

    Sub Main()

        Console.WriteLine("Escriba su nombre:")
        Dim nombreIngresado As String

        Dim edad As Integer
        Dim poblacion As Integer

        Dim precio, altura As Double

        Dim seccion As Char

        Dim mes As String

        Dim esBisiesto As Boolean



        nombreIngresado = Console.ReadLine()

        Console.WriteLine("Ingrese su edad")
        edad = Console.ReadLine()

        Console.WriteLine("Ingrese en numero de alumnos")
        poblacion = Console.ReadLine()

        Console.WriteLine(edad)
        Console.WriteLine(poblacion)


        Console.WriteLine(nombreIngresado + " Bienvenido a curso")



        Console.ReadKey()

    End Sub

End Module
