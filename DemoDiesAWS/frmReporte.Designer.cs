namespace DemoDiesAWS
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.database1DataSet = new DemoDiesAWS.Database1DataSet();
            this.tblNewCLientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNewCLientesTableAdapter = new DemoDiesAWS.Database1DataSetTableAdapters.tblNewCLientesTableAdapter();
            this.tblNewCLientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewCLientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewCLientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblNewCLientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DemoDiesAWS.rptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNewCLientesBindingSource
            // 
            this.tblNewCLientesBindingSource.DataMember = "tblNewCLientes";
            this.tblNewCLientesBindingSource.DataSource = this.database1DataSet;
            // 
            // tblNewCLientesTableAdapter
            // 
            this.tblNewCLientesTableAdapter.ClearBeforeFill = true;
            // 
            // tblNewCLientesBindingSource1
            // 
            this.tblNewCLientesBindingSource1.DataMember = "tblNewCLientes";
            this.tblNewCLientesBindingSource1.DataSource = this.database1DataSet;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewCLientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewCLientesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblNewCLientesBindingSource;
        private Database1DataSetTableAdapters.tblNewCLientesTableAdapter tblNewCLientesTableAdapter;
        private System.Windows.Forms.BindingSource tblNewCLientesBindingSource1;
    }
}