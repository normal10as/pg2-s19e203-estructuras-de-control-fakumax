Imports System
'3.9. Crear un proyecto y un módulo “ConversionMedidas”, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.
Module ConversionMedidas
    Sub Main(args As String())
        menu()
    End Sub
    Sub menu()
        Dim opcion As UShort
        Do While True
            Console.WriteLine(vbTab & "MENU")
            Console.Write("Ingrese unidad a convertir.")
            Console.WriteLine("1) Pie")
            Console.WriteLine("2) Pulgadas")
            Console.WriteLine("3) Yarda")
            Console.WriteLine("4) Centimetros")
            Console.WriteLine("4) Metros")
            Console.WriteLine("5) SALIR")
            Console.WriteLine(vbLf & "Opción : ")
            opcion = Console.ReadLine
            If opcion = 5 Then
                Exit Do
            End If
            Console.Clear()
        Loop

    End Sub
End Module
