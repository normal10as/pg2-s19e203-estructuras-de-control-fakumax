Imports System
'3.16. Crear un proyecto y un m�dulo llamado �Operaciones� que implemente una funci�n
'sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un argumento que debe
'ser una enumeraci�n para las siguientes operaciones: suma, resta, multiplicaci�n y divisi�n.
'Tambi�n debe haber una versi�n de la funci�n que no reciba la enumeraci�n y como
'operaci�n predeterminada resuelva con una suma. Invocarla desde el m�dulo main probando
'las diferentes alternativas y mostrando los resultados por consola. Ej.
'calcular(operaciones.suma, 5, 8).Minimizar la repetici�n de c�digo.
Module Operaciones
    Enum operadores
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Sumar con 2 parametros : " & calcula(operadores.suma, 5, 6))
        Console.WriteLine("Sumar con 3 parametros : " & calcula(operadores.suma, 5, 6, 6))
        Console.WriteLine("Sumar con 4 parametros : " & calcula(operadores.suma, 5, 6, 6, 6))
        Console.WriteLine("Multiplicar con 2 parametros : " & calcula(operadores.multiplicacion, 5, 6))
        Console.WriteLine("Multiplicar con 3 parametros : " & calcula(operadores.multiplicacion, 5, 6, 6))
        Console.WriteLine("Multiplicar con 4 parametros : " & calcula(operadores.multiplicacion, 5, 6, 6, 6))
        Console.WriteLine("Resta con 2 parametros : " & calcula(operadores.resta, 5, 6))
        Console.WriteLine("Resta con 3 parametros : " & calcula(operadores.resta, 5, 6, 6))
        Console.WriteLine("Resta con 4 parametros : " & calcula(operadores.resta, 5, 6, 6, 6))
        Console.WriteLine("Dividir con 2 parametros : " & calcula(operadores.division, 5, 6))
        Console.WriteLine("Dividir con 3 parametros : " & calcula(operadores.division, 5, 6, 6))
        Console.WriteLine("Dividir con 4 parametros : " & calcula(operadores.division, 5, 6, 6, 6))
        Console.WriteLine("Predeterminada : " & calcula(5, 6))
    End Sub
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single) As Single
        Select Case operador
            Case operadores.suma
                Return valor1 + valor2
            Case operadores.resta
                Return valor1 - valor2
            Case operadores.multiplicacion
                Return valor1 * valor2
            Case operadores.division
                Return valor1 / valor2
            Case Else
                Return "Un error ha ocurrido."
        End Select
    End Function
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return calcula(operador, calcula(operador, valor1, valor2), valor3)
    End Function
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return calcula(operador, calcula(operador, valor1, valor2, valor3), valor4)
    End Function
    Function calcula(valor1 As Single, valor2 As Single) As Single
        Return valor1 + valor2
    End Function
End Module
