Imports System
'3.15. Crear un proyecto y un m�dulo �Deposito� para resolver el siguiente planteo: se
'deposita un capital a un plazo de n meses, con una tasa de inter�s de 36% anual (es una
'constante), capitalizable cada mes, es decir, se suman los intereses ganados al capital.
'Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y luego imprima el
'siguiente reporte:
'MES CAPITAL INTERES SALDO
'1 99,999.99 99,999.99 99,999.99
'2 99,999.99 99,999.99 99,999.99
'x xx, xxx.xx xx,xxx.xx xx,xxx.xx
'n 99, 999.99 99, 999.99 99, 999.99
'TOTAL INTERES GANADO: 99,999.99
'Donde:
'MES: es el n�mero de mes.
'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2,
'deber� tener incrementado el inter�s que gan� en el mes 1, y as� sucesivamente.
'INTERES: es el capital por la tasa mensual de inter�s (tasa anual / 12), osea es el valor
'que gana en el mes correspondiente.
'SALDO: es el el capital sumado el inter�s.
'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.
Module Deposito
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
