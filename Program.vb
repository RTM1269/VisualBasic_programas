Imports System
Namespace miEspacio
    Module Program
        Private precioProducto As Integer
        Sub Main(args As String())

            Console.WriteLine("Introduce precio")
            precioProducto = Console.ReadLine()
            Console.WriteLine(calcularIva(precioProducto))
        End Sub


        Private Function calcularIva(precio As Integer)
            Return precio * 0.21
        End Function
    End Module
End Namespace