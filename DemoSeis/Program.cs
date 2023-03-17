using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1Entities entities= new Ejercicio1Entities();
            entities.tblCLientes.Add(new tblCLientes()
            {
                Nombres = "Jose",
                Apellidos = "Perez",
                FechaNacimiento = DateTime.Now.AddYears(-15),
                Sexo = "M",
                Estado = 1,
                Comentario = "Hola mundi",
                FechaIngreso = DateTime.Now,
                TipoDocumento = 1,
                Documento = "123455",
                Balance = 1000

               
            });
              entities.SaveChanges();
        }
    }
}
