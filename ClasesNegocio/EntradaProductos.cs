using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public enum Movimiento
    {
        Entrada,
        Salida
    }

    public class EntradaProductos
    {
        public int Id { get; set; }
        public Producto producto { get; set; }
        public int Stock { get; set; }
        public Movimiento movimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public static List<EntradaProductos> listaMovimiento = new List<EntradaProductos>();


        public static void AgregarProducto(EntradaProductos p)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Movimiento (producto, Stock, movimiento, Cantidad, fechaMovimiento) VALUES (@Producto, @Stock, @Movimiento, @Cantidad, @FechaMovimiento)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(EntradaProductos p)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Movimiento where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p5 = new SqlParameter("@Id", p.Id);
                p5.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarProducto(EntradaProductos p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Movimiento SET Producto = @Producto, Stock = @Stock, Movimiento = @Movimiento, Cantidad = @Cantidad where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = p.ObtenerParametros(cmd, true);
                cmd.ExecuteNonQuery();

            }
        }

        public static List<EntradaProductos> ObtenerMovimiento()
        {
            EntradaProductos movimieto;

            listaMovimiento.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "Select * from Movimiento";
                SqlCommand cmd = new SqlCommand(textoCMD, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    movimieto = new EntradaProductos();
                    movimieto.Id = elLectorDeDatos.GetInt32(0);
                    movimieto.producto = Producto.ObtenerProducto(elLectorDeDatos.GetInt32(1));
                    movimieto.Stock = elLectorDeDatos.GetInt32(2);
                    if (movimieto.movimiento ==0)
                    {
                        movimieto.movimiento = Movimiento.Entrada;
                    }
                    else
                    {
                        movimieto.movimiento = Movimiento.Salida;
                    }         
                    movimieto.Cantidad = elLectorDeDatos.GetInt32(4);
                    movimieto.FechaMovimiento = elLectorDeDatos.GetDateTime(5);

                    listaMovimiento.Add(movimieto);
                }
                return listaMovimiento;
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Producto", this.producto.Id);
            SqlParameter p2 = new SqlParameter("@Stock", this.Stock);
            SqlParameter p3 = new SqlParameter("@Movimiento", this.movimiento);
            SqlParameter p4 = new SqlParameter("@Cantidad", this.Cantidad);
            SqlParameter p5 = new SqlParameter("@FechaMovimiento", DateTime.Today);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.DateTime;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p5 = new SqlParameter("@id", this.Id);
            p5.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p5);
            return cmd;
        }

        public static void ActualizarStock(EntradaProductos p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Producto SET Cantidad = @Cantidad where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = p.ObtenerParametros(cmd, true);
                cmd.ExecuteNonQuery();

            }
        }

    }
}
