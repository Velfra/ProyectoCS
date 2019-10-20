using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class Proveedor
    {
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return NombreProveedor;
        }

        public static List<Proveedor> listaProveedores = new List<Proveedor>();

        public static List<Proveedor> ObtenerProveedores()
        {
            return listaProveedores;
        }

      

        public static void AgregarProveedor(Proveedor p)
        {
            listaProveedores.Add(p);
        }

        public static void EliminarProveedor(Proveedor p)
        {
            listaProveedores.Remove(p);
        }

        public static void EditarProveedor(Proveedor p, int indice)
        {

            Proveedor.listaProveedores[indice] = p;
        }
    }
}
