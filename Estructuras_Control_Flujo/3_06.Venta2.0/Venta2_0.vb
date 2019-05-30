Imports System
'3.6. Crear un proyecto y un módulo “Venta2.0”, para resolver el problema “Venta” (3.4) con
'Case .
Module Venta2_0
    Sub Main(args As String())
        Dim cantidad As UShort
        Dim precio As Single
        Console.Write("Ingrese la cantidad : ")
        cantidad = Console.ReadLine
        Console.Write("Ingrese el precio : ")
        precio = Console.ReadLine
        impresion(cantidad, precio)
    End Sub
    Sub impresion(cantidad As UShort, precio As Single)
            Dim total As Decimal = cantidad * precio
            Dim porciento As Single = porcentaje(cantidad)
            Console.WriteLine(vbTab & "VENTA")
            Console.WriteLine("Subtotal :  $" & total)
            Console.WriteLine("Descuento : '{0}'%", porciento * 100)
            Console.WriteLine("A descontar : ${0} ", total * porciento)
            Console.WriteLine("TOTAL : ${0}", total - (total * porciento))

        End Sub
    Function porcentaje(cantidad) As Single
        Select Case cantidad
            Case 10 To 50
                Return 0.05
            Case 51 To 250
                Return 0.1
            Case > 250
                Return 0.2
            Case Else
                Return 0
        End Select
    End Function
End Module


