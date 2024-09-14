namespace winform_app
{
    partial class frmBuscarArticulo
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
            this.dgvBuscarArt = new System.Windows.Forms.DataGridView();
            this.PbImagen = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBoxFiltro = new System.Windows.Forms.TextBox();
            this.btnImagenDer = new System.Windows.Forms.Button();
            this.btnImagenIzq = new System.Windows.Forms.Button();
            this.lblCantImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarArt
            // 
            this.dgvBuscarArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarArt.Location = new System.Drawing.Point(12, 52);
            this.dgvBuscarArt.Name = "dgvBuscarArt";
            this.dgvBuscarArt.Size = new System.Drawing.Size(830, 343);
            this.dgvBuscarArt.TabIndex = 0;
            this.dgvBuscarArt.CurrentCellChanged += new System.EventHandler(this.dgvBuscarArt_CurrentCellChanged);
            // 
            // PbImagen
            // 
            this.PbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImagen.Location = new System.Drawing.Point(848, 52);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(212, 200);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagen.TabIndex = 1;
            this.PbImagen.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Gray;
            this.lblFiltro.Location = new System.Drawing.Point(12, 29);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(99, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Ingresar Busqueda:";
            // 
            // txtBoxFiltro
            // 
            this.txtBoxFiltro.Location = new System.Drawing.Point(117, 26);
            this.txtBoxFiltro.Name = "txtBoxFiltro";
            this.txtBoxFiltro.Size = new System.Drawing.Size(243, 20);
            this.txtBoxFiltro.TabIndex = 3;
            this.txtBoxFiltro.TextChanged += new System.EventHandler(this.txtBoxFiltro_TextChanged);
            // 
            // btnImagenDer
            // 
            this.btnImagenDer.Location = new System.Drawing.Point(993, 258);
            this.btnImagenDer.Name = "btnImagenDer";
            this.btnImagenDer.Size = new System.Drawing.Size(67, 23);
            this.btnImagenDer.TabIndex = 4;
            this.btnImagenDer.Text = ">";
            this.btnImagenDer.UseVisualStyleBackColor = true;
            this.btnImagenDer.Visible = false;
            this.btnImagenDer.Click += new System.EventHandler(this.btnImagenDer_Click);
            // 
            // btnImagenIzq
            // 
            this.btnImagenIzq.Location = new System.Drawing.Point(848, 258);
            this.btnImagenIzq.Name = "btnImagenIzq";
            this.btnImagenIzq.Size = new System.Drawing.Size(68, 23);
            this.btnImagenIzq.TabIndex = 5;
            this.btnImagenIzq.Text = "<";
            this.btnImagenIzq.UseVisualStyleBackColor = true;
            this.btnImagenIzq.Visible = false;
            this.btnImagenIzq.Click += new System.EventHandler(this.btnImagenIzq_Click);
            // 
            // lblCantImagen
            // 
            this.lblCantImagen.AutoSize = true;
            this.lblCantImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantImagen.Location = new System.Drawing.Point(951, 263);
            this.lblCantImagen.Name = "lblCantImagen";
            this.lblCantImagen.Size = new System.Drawing.Size(0, 13);
            this.lblCantImagen.TabIndex = 6;
            // 
            // frmBuscarArticulo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1132, 430);
            this.Controls.Add(this.lblCantImagen);
            this.Controls.Add(this.btnImagenIzq);
            this.Controls.Add(this.btnImagenDer);
            this.Controls.Add(this.txtBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.dgvBuscarArt);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarCodigo;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.DataGridView dgvBuscarArticulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBuscarArt;
        private System.Windows.Forms.PictureBox PbImagen;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBoxFiltro;
        private System.Windows.Forms.Button btnImagenDer;
        private System.Windows.Forms.Button btnImagenIzq;
        private System.Windows.Forms.Label lblCantImagen;
    }
}