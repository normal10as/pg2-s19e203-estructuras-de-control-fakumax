Imports System
'3.20. Elaborar un algoritmo que lea un n�mero N, que imprima la sumatoria de los
'cuadrados de los enteros entre 1 y N. Utilizar un m�todo para el c�lculo de la sumatoria v�a
'par�metro por referencia. Utilizar un m�todo para validar los valores ingresados sean enteros
'positivos, si no cumple esta condici�n pedir el reingreso del dato.
Module NumeroN
    Sub Main(args As String())
        Dim sumaTotal As Integer
        For x = 1 To valida()
            sumatoria(sumaTotal, x)
        Next
        Console.WriteLine("El resultado es : " & sumaTotal)
    End Sub
    Function valida() As Integer
        Dim NumeroN As Integer
        Do
            Console.Write("Ingrese un n�mero : ")
            NumeroN = Console.ReadLine
            If NumeroN = 0 Then
                Console.WriteLine("Reingrese un n�mero positivo.")
            End If
        Loop Until NumeroN > 0
        Return NumeroN
    End Function
    Sub sumatoria(ByRef sumaTotal As Integer, NumeroN As Integer)
        sumaTotal += NumeroN ^ 2
    End Sub
End Module
