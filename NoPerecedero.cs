using System;


namespace Tienda
{

    public class NoPerecedero : Producto
    {
        private string Categoria;

        public NoPerecedero(string nombre, decimal precio, string tipo, string categoria) : base(nombre, precio, tipo)
        {
            Categoria = categoria;
        }

        // Propiedades
        public string CategoriaPropiedad => Categoria;

        public override decimal CalcularPrecioTotal(int cantidad)
        {
            return Precio * cantidad;
        }

        public override string ToString()
        {
            return base.ToString() + $", Categoría: {Categoria}";
        }
    }
}