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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarArt
            // 
            this.dgvBuscarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarArt.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvBuscarArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarArt.Location = new System.Drawing.Point(9, 39);
            this.dgvBuscarArt.Name = "dgvBuscarArt";
            this.dgvBuscarArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarArt.Size = new System.Drawing.Size(662, 284);
            this.dgvBuscarArt.TabIndex = 0;
            this.dgvBuscarArt.CurrentCellChanged += new System.EventHandler(this.dgvBuscarArt_CurrentCellChanged);
            // 
            // PbImagen
            // 
            this.PbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImagen.Location = new System.Drawing.Point(677, 39);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(212, 200);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagen.TabIndex = 1;
            this.PbImagen.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblFiltro.Location = new System.Drawing.Point(14, 333);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(69, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtBoxFiltro
            // 
            this.txtBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFiltro.Location = new System.Drawing.Point(89, 330);
            this.txtBoxFiltro.Name = "txtBoxFiltro";
            this.txtBoxFiltro.Size = new System.Drawing.Size(301, 20);
            this.txtBoxFiltro.TabIndex = 3;
            this.txtBoxFiltro.TextChanged += new System.EventHandler(this.txtBoxFiltro_TextChanged);
            // 
            // btnImagenDer
            // 
            this.btnImagenDer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagenDer.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnImagenDer.Enabled = false;
            this.btnImagenDer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenDer.Location = new System.Drawing.Point(822, 245);
            this.btnImagenDer.Name = "btnImagenDer";
            this.btnImagenDer.Size = new System.Drawing.Size(67, 30);
            this.btnImagenDer.TabIndex = 4;
            this.btnImagenDer.Text = ">";
            this.btnImagenDer.UseVisualStyleBackColor = false;
            this.btnImagenDer.Click += new System.EventHandler(this.btnImagenDer_Click);
            // 
            // btnImagenIzq
            // 
            this.btnImagenIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagenIzq.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnImagenIzq.Enabled = false;
            this.btnImagenIzq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenIzq.Location = new System.Drawing.Point(677, 245);
            this.btnImagenIzq.Name = "btnImagenIzq";
            this.btnImagenIzq.Size = new System.Drawing.Size(68, 30);
            this.btnImagenIzq.TabIndex = 5;
            this.btnImagenIzq.Text = "<";
            this.btnImagenIzq.UseVisualStyleBackColor = false;
            this.btnImagenIzq.Click += new System.EventHandler(this.btnImagenIzq_Click);
            // 
            // lblCantImagen
            // 
            this.lblCantImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantImagen.AutoSize = true;
            this.lblCantImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantImagen.Location = new System.Drawing.Point(785, 254);
            this.lblCantImagen.Name = "lblCantImagen";
            this.lblCantImagen.Size = new System.Drawing.Size(0, 13);
            this.lblCantImagen.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(814, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCampo.Location = new System.Drawing.Point(12, 15);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCriterio.Location = new System.Drawing.Point(193, 15);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(377, 16);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(58, 13);
            this.lblFiltroAvanzado.TabIndex = 10;
            this.lblFiltroAvanzado.Text = "Búsqueda:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(441, 13);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(677, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 21);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(241, 12);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(100, 21);
            this.cbCriterio.TabIndex = 15;
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(62, 12);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(100, 21);
            this.cbCampo.TabIndex = 16;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // frmBuscarArticulo
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(904, 361);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCantImagen);
            this.Controls.Add(this.btnImagenIzq);
            this.Controls.Add(this.btnImagenDer);
            this.Controls.Add(this.txtBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.dgvBuscarArt);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda Avanzada";
            this.Load += new System.EventHandler(this.frmBuscarArticulo_Load);
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.ComboBox cbCampo;
    }
}