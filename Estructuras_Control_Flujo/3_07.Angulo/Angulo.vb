Imports System
'3.7. Crear un proyecto y un m�dulo �Angulo� para resolver con CASE: ingresar el tama�o de un
'�ngulo en grados e imprimir el mensaje correspondiente seg�n la siguiente tabla:
'Agudo si es menor a 90�
'Recto si es igual a 90�
'Obtuso si es mayor que 90� pero menor que 180�
'Llano si es igual a 180�
'C�ncavo si es mayor que 180� pero menor que 360�
'Error Si el valor es menor a 0� o mayor de 360�
Module Angulo
    Sub Main(args As String())
        Dim valor As UShort
        Console.WriteLine("Ingrese el Angulo : ")
        valor = Console.ReadLine
        Console.WriteLine(tamanioAngulo(valor))
    End Sub
    Function tamanioAngulo(valor As UShort) As String
        Select Case valor
            Case 1 To 89
                Return "�ngulo Agudo"
            Case 90
                Return "�ngulo Recto"
            Case 90 To 179
                Return "�ngulo Obtuso"
            Case 180
                Return "�ngulo Llano"
            Case 181 To 359
                Return "�ngulo C�ncavo"
            Case 360
                Return "�ngulo Completo"
            Case Else
                Return "Error"
        End Select
    End Function
End Module
