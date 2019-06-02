Imports System
'3.12. Crear un proyecto y un m�dulo �Fibonacci� para elaborar �Los n�meros de
'Fibonacci�, estos constituyen una secuencia que empieza con 0 y 1; el n�mero que sigue a
'�stos se calcula sumando los dos anteriores y as� sucesivamente. Utilizando la estructura de
'repetici�n m�s adecuada elaborar un algoritmo que imprima los 20 primeros n�meros de la
'secuencia.
Module Fibonacci
    Sub Main(args As String())
        fibonacci(20)
    End Sub
    Sub fibonacci(numero As UInteger)
        Dim z As Integer
        Dim x As Integer = 0
        Dim y As Integer = 1
        For r As Integer = 1 To numero
            x = y
            y = z
            z = x + y
            Console.WriteLine("{0} + {1} = {2}", x, y, z)
        Next
    End Sub
End Module
