using System;
using System.Collections.Generic;

namespace Tienda
{
    public class Test
    {
        static void Main(string[] args)
        {
            List<Producto> Productos = new List<Producto>();

            // Agregar productos correctamente instanciando clases derivadas
            Productos.Add(new Perecedero("Queso", 20000.00m, "Lácteos", 2));
            Productos.Add(new NoPerecedero("Leche en polvo", 10000.00m, "Lácteos", "Almacén"));

            // Calcular y mostrar el precio total de vender 5 productos de cada tipo
            foreach (var producto in Productos)
            {
                //Convertir el formato en que se muestra el precio a sólo dos decimales, para el caso en que resdulten nros periódicos o irracioneles
                decimal precioFinalProducto = producto.CalcularPrecioTotal(5);
                string darFormato = ".00";
                string precioFinal = precioFinalProducto.ToString(darFormato);

                //Mostrar en pantalla los detalles

                Console.WriteLine($"Producto: {producto.Nombre} \nTipo: {producto.Tipo} \nPrecio unitario: $ {producto.Precio} \nCantidad: 5 \nPrecio final: $ {precioFinal}");
                
                //Si es perecedero, se muestran los días que faltan para la caducidad
                if (producto is Perecedero perecedero)
                {
                    Console.WriteLine($"Días faltantes para vencimiento: {perecedero.DiasACaducar}\n");
                }
            }
        }
    }
}