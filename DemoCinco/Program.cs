using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCinco
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("Hello logging world!");
            log.Error("Esto es un error");
            log.Fatal("Esto es un error critico");
            log.Debug("Esto es un mensaje de depuracion");

            EventLog logWR = new EventLog();

            logWR.Source = "Application";
            logWR.WriteEntry("Saldos desde la aplicacion", EventLogEntryType.Information);
            
        }
    }
}
