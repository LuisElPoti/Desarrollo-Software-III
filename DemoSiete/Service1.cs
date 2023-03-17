using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoSiete
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            
        }

        protected override void OnStop()
        {
        }

        private void fswMonitor_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"c:\log.txt", true);
            sw.WriteLine(e.Name + ">Cambiado");
            sw.Flush();
            sw.Close();
        }

        private void fswMonitor_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"c:\log.txt",true);
            sw.WriteLine(e.Name + ">Creado");
            sw.Flush();
            sw.Close();
        }

        private void fswMonitor_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"c:\log.txt", true);
            sw.WriteLine(e.Name + ">Borrado");
            sw.Flush();
            sw.Close();
        }

        private void fswMonitor_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"c:\log.txt", true);
            sw.WriteLine(e.Name + ">renombrado");
            sw.Flush();
            sw.Close();
        }
    }
}
