Imports System
Namespace Ejercicios

    Module Iva
        Private precioProducto As Integer
        Private resultado As Integer
        Private radio As Double

        Sub Main(args As String())
            'Console.WriteLine("Ejercicio 2:")
            'Console.WriteLine("Introduce precio")
            'precioProducto = Console.ReadLine()
            'Console.WriteLine("Precio con IVA: {0}", calcularIva(precioProducto))
            'Console.WriteLine()
            'Console.WriteLine("Ejercicio 3:")
            'pintarTablas()
            'Console.WriteLine()
            'Console.WriteLine("Ejercicio 4:")
            'Console.WriteLine("Introduce radio")
            'radio = Console.ReadLine()
            'Console.WriteLine("El area del radio introducido anteriormente es: {0}", AreaCuadrado(radio))
            'Console.WriteLine()
            Console.WriteLine("Ejercicio 5:")
            Divisible()

        End Sub

        'Crea un programa que calcule el IVA de un producto. El valor de este producto se pasará por teclado
        'y nos mostrará por pantalla el valor del IVA y su valor final. El IVA es el 21 %. 
        'Por ejemplo, si introducimos 100como valor de producto, el IVA es 21 y el valor final es 121.
        Private Function calcularIva(precio As Integer)
            Return precio + precio * 0.21
        End Function
        'Crea un programa que calcule el IVA de un producto.
        'El valor de este producto se pasará por teclado y nos mostrará por pantalla el valor del IVA y su valor final. El IVA es el 21 %.
        'Por ejemplo, si introducimos 100como valor de producto, el IVA es 21 y el valor final es 121.
        Private Sub pintarTablas()
            Console.WriteLine("TABLAS DEL 1-10:")
            Dim i, j As Integer
            i = 1
            j = 1
            While (i < 10) '+ i * j
                While (j < 10)
                    resultado = i * j
                    Console.Write(" " + resultado.ToString)
                    j += 1
                End While
                resultado = i * j
                Console.WriteLine(" " + resultado.ToString)
                i += 1
                j = 0
            End While
        End Sub
        ' Crea un programa que nos calcula el area un cuadrado.
        ' Tenemos que pedir el radio de la circunferencia.
        ' Podemos obtener el valor de PI, con Math.PI
        Private Function AreaCuadrado(radio As Double)
            Return radio * Math.PI
        End Function
        'Pide dos números por teclado. Indica si el primer número es divisible por el segundo.
        'Por ejemplo, si introduzco 10 y 2, si es divisible, por que si divides 10 entre 2, el resto es 0.
        Private Sub Divisible()
            Dim n1, n2 As Integer
            Console.WriteLine("Introduce el primer numero:")
            n1 = Console.ReadLine()
            Console.WriteLine("Introduce el segundo numero:")
            n2 = Console.ReadLine()
            If n1 Mod n2 = 0 Then
                Console.WriteLine("es divisible")
            Else
                Console.WriteLine("NO es divisible")
            End If
        End Sub

    End Module


End Namespace