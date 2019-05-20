Imports System
'3.2. Crear un proyecto y un módulo “Menor” para resolver con IF: ingresar tres valores y mostrar
'el menor.
Module Menor
    Sub Main(args As String())
        Console.WriteLine("El resultado menor es : " & menor())
    End Sub
    Function menor() As String
        Dim menorValor As Integer
        Dim valor(2) As Integer
        For x = 0 To 2
            Console.WriteLine("Ingrese el valor '{0}' : ", x + 1)
            valor(x) = Console.ReadLine
            If x = 0 Then
                menorValor = valor(0)
            ElseIf valor(x) < menorValor Then
                menorValor = valor(x)
            End If
        Next
        Return menorValor
    End Function
End Module
