using System;

namespace Tienda
{
    public abstract class Producto
    {
        private string nombre;
        private decimal precio;
        private string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Producto(string nombre, decimal precio, string tipo)
        {
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
        }


        public abstract decimal CalcularPrecioTotal(int cantidad);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Precio: {Precio}, Tipo: {Tipo}";
        }
    }
}