Imports System
Imports System.Math
'3.3. Crear un proyecto y un módulo “Tercero” para resolver con IF ingresar 5 valores enteros e
'informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.
Module Tercero
    Sub Main(args As String())
        Dim valor1, valor2, valor3, valor4, valor5 As Integer
        Console.WriteLine("Ingrese un valor :")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese un valor :")
        valor2 = Console.ReadLine
        Console.WriteLine("Ingrese un valor :")
        valor3 = Console.ReadLine
        Console.WriteLine("Ingrese un valor :")
        valor4 = Console.ReadLine
        Console.WriteLine("Ingrese un valor :")
        valor5 = Console.ReadLine
        Console.WriteLine("El número '{0}' está en la posición {1} : ", mayor(valor1, valor2, valor3, valor4, valor5))
    End Sub
    Function mayor(valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer, valor5 As Integer) As String
        Dim aux As Integer = 1
        If valor1 > valor2 Then
            Max(valor1, valor2)
        End If
        Return ""
    End Function


End Module
