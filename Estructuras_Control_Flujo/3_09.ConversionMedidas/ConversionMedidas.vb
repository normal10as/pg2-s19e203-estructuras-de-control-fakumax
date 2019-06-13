Imports System
'3.9. Crear un proyecto y un m�dulo �ConversionMedidas�, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, cent�metros,
'yardas, pies y pulgadas: 
'� Presentar un men� y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y despu�s mostrar las equivalencias.
'� Utilizar �nicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'� Ejemplo: si escogi� metros, debe solicitar y leer el n�mero de metros a convertir, luego
'imprimir la equivalencia en cent�metros, pies, yardas y pulgadas.
Module ConversionMedidas
    Sub Main(args As String())
        Dim valor As Integer
        Dim opcion As Byte
        Do While True
            opcion = menu()
            If opcion = 6 Then
                Exit Do
            ElseIf opcion > 1 Or opcion < 6 Then
                Console.Write("Ingrese el valor : ")
                valor = Console.ReadLine
                'Console.Clear()
                'Console.WriteLine()
                Select Case opcion
                    Case 1
                        pie(valor)
                    Case 2
                        pulgada(valor)
                    Case 3
                        yarda(valor)
                    Case 4
                        centimetro(valor)
                    Case 5
                        metro(valor)
                End Select
            Else
                Console.WriteLine("Numero Erroneo, reintente")
            End If
        Loop
    End Sub
    Function menu() As Byte
        Console.WriteLine(vbTab & "MENU")
        Console.WriteLine("Ingrese unidad a convertir.")
        Console.WriteLine("1) Pie")
        Console.WriteLine("2) Pulgadas")
        Console.WriteLine("3) Yarda")
        Console.WriteLine("4) Centimetros")
        Console.WriteLine("5) Metros")
        Console.WriteLine("6) SALIR")
        Console.Write(vbLf & "Opci�n : ")
        Return Console.ReadLine
    End Function
    Sub pie(valor As Integer)
        Console.WriteLine(vbTab & "Conversi�n PIE")
        Console.WriteLine("> Pulgadas: " & valor * 12)
        Console.WriteLine("> Yardas: " & valor / 3)
        Console.WriteLine("> Cent�metros: " & valor * 12 * 2.54)
        Console.WriteLine("> Metros: " & (valor * 12 * 2.54) / 100)
    End Sub
    Sub yarda(valor As Integer)
        Console.WriteLine(vbTab & "Conversi�n YARDA")
        Console.WriteLine("> Pulgadas: " & valor * 3 * 12)
        Console.WriteLine("> Pie : " & valor * 3)
        Console.WriteLine("> Cent�metros: " & valor * 3 * 12 * 2.54)
        Console.WriteLine("> Metros: " & valor * 3 * 12 * 2.54 * 100)
    End Sub
    Sub pulgada(valor As Integer)
        Console.WriteLine(vbTab & "Conversi�n PULGADAS")
        Console.WriteLine("> Pie: " & valor / 12)
        Console.WriteLine("> Yardas: " & (valor / 12) / 3)
        Console.WriteLine("> Cent�metros: " & valor * 2.54)
        Console.WriteLine("> Metros: " & (valor * 2.54 * 100))
    End Sub
    Sub metro(valor As Integer)
        Console.WriteLine(vbTab & "Conversi�n METRO")
        Console.WriteLine("> Pie: " & (valor * 2.54 * 100) / 12)
        Console.WriteLine("> Pulgadas: " & valor * 2.54 * 100)
        Console.WriteLine("> Yardas: " & ((valor * 100 * 2.54) / 12) / 3)
        Console.WriteLine("> Cent�metros: " & valor * 100)
    End Sub
    Sub centimetro(valor As Integer)
        Console.WriteLine(vbTab & "Conversi�n CENTIMETROS")
        Console.WriteLine("> Pie: " & (valor * 2.54) / 12)
        Console.WriteLine("> Pulgadas: " & valor * 2.54)
        Console.WriteLine("> Yardas: " & ((valor * 100 * 2.54) / 12) / 3)
        Console.WriteLine("> Metros: " & valor / 100)
    End Sub
End Module
