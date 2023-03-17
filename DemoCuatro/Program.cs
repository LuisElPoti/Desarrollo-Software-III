using DemoCuatro.MyDsTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoCuatro.MyDs;

namespace DemoCuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tblCLientesTableAdapter adapter = new tblCLientesTableAdapter();
            adapter.Insert("Mario", "Rodriguez", DateTime.Now.AddYears(20),"M",1,"Hola",DateTime.Now,1,"123456",500M);
            tblCLientesDataTable tblClientes = adapter.GetDataByApellido("Rodriguez");
            foreach (var item in tblClientes)
            {
                Console.WriteLine($"{item.Nombres} - {item.Apellidos}");
            }
            SqlTransaction transaction= null;
            try
            {
                adapter.Connection.Open();
                transaction = adapter.Connection.BeginTransaction();
                adapter.Transaction = transaction;

                adapter.dpUpsertCliente("Mario", "Rodriguez", DateTime.Now.AddYears(20), "M", "Hola", 1, "123456", 500M, 1);
                adapter.dpInsertMovimiento(1, "123456", 500M, "Cr", 1, "agregado", "Blue Mall");
                transaction.Commit();
            }
            catch (Exception crr)
            {
                transaction.Rollback();
                throw;
            }
            
        }
    }
}
