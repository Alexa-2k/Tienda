using System;


namespace Tienda
{
    public class Perecedero : Producto
    {
        private int diasACaducar;

        public Perecedero(string nombre, decimal precio, string tipo, int diasACaducar) : base(nombre, precio, tipo)
        {
            DiasACaducar = diasACaducar;
        }

        public int DiasACaducar { get => diasACaducar; set => diasACaducar = value; }

        // Propiedades


        public override decimal CalcularPrecioTotal(int cantidad)
        {
            decimal precioFinal = Precio * cantidad;
            if (DiasACaducar == 1)
            {
                precioFinal /= 4; // Se reduce 4 veces
            }
            else if (DiasACaducar == 2)
            {
                precioFinal *= 0.33m; // Se reduce 3 veces
            }
            else if (DiasACaducar == 3)
            {
                precioFinal /= 2; // Se reduce a la mitad
            }
            return precioFinal;
        }

        public override string ToString()
        {
            return base.ToString() + $", Días a caducar: {DiasACaducar}";
        }
    }
}