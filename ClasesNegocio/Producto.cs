using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class Producto
    {
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public Categoria categoria { get; set; }
        public double Precio_Costo { get; set; }
        public Proveedor proveedor { get; set; }

        public static List<Producto> listaProducto = new List<Producto>();

        public static List<Producto> ObtenerProducto()
        {
            return listaProducto;
        }



        public static void AgregarProducto(Producto p)
        {
            listaProducto.Add(p);
        }

        public static void EliminarProducto(Producto p)
        {
            listaProducto.Remove(p);
        }

        public static void EditarProducto(Producto p, int indice)
        {

            Producto.listaProducto[indice] = p;
        }
        public override string ToString()
        {
            return this.Nombre_Producto;
        }
    }
}
