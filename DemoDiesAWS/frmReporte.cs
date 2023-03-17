using DemoDiesAWS.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDiesAWS
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tblNewCLientes' table. You can move, or remove it, as needed.
            this.tblNewCLientesTableAdapter.Fill(this.database1DataSet.tblNewCLientes);
            tblNewCLientesTableAdapter adapter = new tblNewCLientesTableAdapter();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
