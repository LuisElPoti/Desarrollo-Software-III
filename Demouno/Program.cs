using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demouno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 's';

            while(a != 'n')
            {
                SqlTransaction transaction = null;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cn"].ConnectionString);
                cn.Open();

                Console.WriteLine(cn.State);

                SqlCommand cm = new SqlCommand($"ppGetCliente", cn);

                cm.CommandType = System.Data.CommandType.StoredProcedure;

                Cliente cliente = new Cliente();

                Console.WriteLine("TipoDocumento: ");
                cliente.TipoDocumento = int.Parse(Console.ReadLine());
                Console.WriteLine("Documento: ");
                cliente.Documento = Console.ReadLine();

                cm.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                cm.Parameters.AddWithValue("@Documento", cliente.Documento);

                SqlDataReader dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    Console.WriteLine("Nombre: " + dr["Nombres"].ToString());
                    cliente.Nombres = dr["Nombres"].ToString();
                    Console.WriteLine("Apellido: " + dr["Apellidos"].ToString());
                    cliente.Apellidos = dr["Apellidos"].ToString();
                    Console.WriteLine("FechaNacimiento: " + dr["FechaNacimiento"].ToString());
                    cliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                    Console.WriteLine("Sexo: " + dr["Sexo"].ToString());
                    cliente.Sexo = dr["Sexo"].ToString();
                    cliente.Estado = 1;
                    Console.WriteLine("Comentario: " + dr["Comentario"].ToString());
                    cliente.Comentario = dr["Sexo"].ToString();
                }

                else
                {
                    Console.WriteLine("Nombre: ");
                    cliente.Nombres = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    cliente.Apellidos = Console.ReadLine();
                    Console.WriteLine("FechaNacimeinto: ");
                    cliente.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Sexo: ");
                    cliente.Sexo = Console.ReadLine();
                    cliente.Estado = 1;
                    Console.WriteLine("Comentario: ");
                    cliente.Comentario = Console.ReadLine();
                }


                dr.Close();
                Console.WriteLine("Monto: ");
                cliente.Balance = decimal.Parse(Console.ReadLine());


                Movimiento movimiento = new Movimiento();

                Console.WriteLine("DbCr: ");
                movimiento.DbCr = Console.ReadLine();

                Console.WriteLine("Tipo de Transaccion: ");
                movimiento.TipoTransaccion = int.Parse(Console.ReadLine());

                cm.Parameters.Clear();
                cm.CommandText = "dpUpsertCliente";

                cm.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cm.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                cm.Parameters.AddWithValue("@Sexo", cliente.Sexo);

                cm.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                cm.Parameters.AddWithValue("@Documento", cliente.Documento);
                cm.Parameters.AddWithValue("@Balance", cliente.Balance);
                cm.Parameters.AddWithValue("@Comentario", cliente.Comentario);
                cm.Parameters.AddWithValue("@TipoTransaccion", movimiento.TipoTransaccion);

                try
                {
                    transaction = cn.BeginTransaction();
                    cm.Transaction = transaction;
                    cm.ExecuteNonQuery();

                    cm.Parameters.Clear();
                    cm.CommandText = "dpInsertMovimiento";

                    cm.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                    cm.Parameters.AddWithValue("@Documento", cliente.Documento);
                    cm.Parameters.AddWithValue("@TipoTransaccion", movimiento.TipoTransaccion);
                    cm.Parameters.AddWithValue("@Monto", cliente.Balance);
                    cm.Parameters.AddWithValue("@DbCr", movimiento.DbCr);
                    cm.Parameters.AddWithValue("@Descripcion", cliente.Comentario);

                    cm.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

                Console.WriteLine("Desea continuar? s/n");
                a = char.Parse( Console.ReadLine());
            }
 
        }
    }
}
