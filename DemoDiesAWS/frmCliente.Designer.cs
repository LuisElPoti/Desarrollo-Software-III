namespace DemoDiesAWS
{
    partial class frmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.txtSalida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(186, 93);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(332, 96);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(84, 27);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(104, 144);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(468, 255);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(598, 177);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(84, 27);
            this.btnExplorar.TabIndex = 4;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(104, 416);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(468, 96);
            this.txtSalida.TabIndex = 5;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 524);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.TextBox txtSalida;
    }
}