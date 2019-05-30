Imports System
'3.8. Crear un proyecto y un m�dulo �DiasMes� para resolver con CASE: Elabore un programa
'que indique cuantos d�as tiene un mes respetando los siguientes requerimientos:
'� En el flujo normal se ingresa el n�mero de mes a evaluar y mediante una enumeraci�n
'se informa la cantidad de d�as que tiene el mes.
'� En el caso de ser febrero, adem�s ingresar el a�o y tener en cuenta que tiene 28 d�as y si
'es un a�o bisiesto tiene 29 d�as. Un a�o bisiesto es aqu�l que es m�ltiplo de 4 y no de 100
'o cuando es m�ltiplo de 400. Por ejemplo, el a�o 2000 si bisiesto pero el 2100 no lo es.
Module DiasMes
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub Main(args As String())
        Dim mes As meses
        Console.Write("Ingrese un valor para mostrar el mes : ")
        mes = Console.ReadLine
        Console.WriteLine(mostrarMeses(mes))
    End Sub
    Function mostrarMeses(mes As meses) As String
        Select Case mes
            Case meses.Enero, meses.Marzo, meses.Mayo, meses.Julio, meses.Agosto, meses.Octubre, meses.Diciembre
                Return "El mes tiene 31 d�as"
            Case meses.Febrero
                Return febrero()
            Case meses.Abril, meses.Junio, meses.Septiembre, meses.Noviembre
                Return "El mes tiene 30 d�as"
            Case Else
                Return "Error de mes ingresado"
        End Select
    End Function
    Function febrero() As String
        Dim valor As UShort
        Console.Write("Ingrese el a�o 'AAAA' : ")
        valor = Console.ReadLine
        If valor Mod 4 = 0 And valor Mod 100 <> 0 Or valor Mod 400 = 0 Then
            Return "El mes tiene 29 d�as, es bisiesto"
        Else
            Return "El mes tiene 28 d�as"
        End If
    End Function
End Module
