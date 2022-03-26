using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, decimal precio, int existencia, byte[] imagen)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            Imagen = imagen;
        }
    }
}
