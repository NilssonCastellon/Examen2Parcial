using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Parcial_NilssonCastellon
{
    public class Pedidos
    {

        public FrmPedidos()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        Pedidos pedidos = new Pedidos();
        Producto producto;
        PedidosDA pedidosDA = new PedidosDA();

    }
}
