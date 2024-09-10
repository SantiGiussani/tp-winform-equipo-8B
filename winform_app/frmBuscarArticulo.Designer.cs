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
            this.lblIngresarCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBuscarArticulo = new System.Windows.Forms.DataGridView();
            this.lblBuscarXnombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarXnombre = new System.Windows.Forms.Button();
            this.lblBuscarXdesc = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.btnBuscarXdesc = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarCodigo
            // 
            this.lblIngresarCodigo.AutoSize = true;
            this.lblIngresarCodigo.Location = new System.Drawing.Point(25, 112);
            this.lblIngresarCodigo.Name = "lblIngresarCodigo";
            this.lblIngresarCodigo.Size = new System.Drawing.Size(86, 13);
            this.lblIngresarCodigo.TabIndex = 0;
            this.lblIngresarCodigo.Text = "Ingresar codigo: ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(107, 112);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(209, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(107, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(209, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBuscarArticulo
            // 
            this.dgvBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarArticulo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBuscarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarArticulo.Location = new System.Drawing.Point(384, 43);
            this.dgvBuscarArticulo.Name = "dgvBuscarArticulo";
            this.dgvBuscarArticulo.Size = new System.Drawing.Size(669, 399);
            this.dgvBuscarArticulo.TabIndex = 3;
            // 
            // lblBuscarXnombre
            // 
            this.lblBuscarXnombre.AutoSize = true;
            this.lblBuscarXnombre.Location = new System.Drawing.Point(22, 174);
            this.lblBuscarXnombre.Name = "lblBuscarXnombre";
            this.lblBuscarXnombre.Size = new System.Drawing.Size(89, 13);
            this.lblBuscarXnombre.TabIndex = 4;
            this.lblBuscarXnombre.Text = "Ingresar nombre: ";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(107, 174);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(209, 20);
            this.txtBoxNombre.TabIndex = 5;
            // 
            // btnBuscarXnombre
            // 
            this.btnBuscarXnombre.Location = new System.Drawing.Point(107, 201);
            this.btnBuscarXnombre.Name = "btnBuscarXnombre";
            this.btnBuscarXnombre.Size = new System.Drawing.Size(209, 23);
            this.btnBuscarXnombre.TabIndex = 6;
            this.btnBuscarXnombre.Text = "Buscar";
            this.btnBuscarXnombre.UseVisualStyleBackColor = true;
            this.btnBuscarXnombre.Click += new System.EventHandler(this.btnBuscarXnombre_Click);
            // 
            // lblBuscarXdesc
            // 
            this.lblBuscarXdesc.AutoSize = true;
            this.lblBuscarXdesc.Location = new System.Drawing.Point(25, 245);
            this.lblBuscarXdesc.Name = "lblBuscarXdesc";
            this.lblBuscarXdesc.Size = new System.Drawing.Size(105, 13);
            this.lblBuscarXdesc.TabIndex = 7;
            this.lblBuscarXdesc.Text = "Ingresar descripcion:";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(136, 245);
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(179, 20);
            this.txtBoxDesc.TabIndex = 8;
            // 
            // btnBuscarXdesc
            // 
            this.btnBuscarXdesc.Location = new System.Drawing.Point(137, 272);
            this.btnBuscarXdesc.Name = "btnBuscarXdesc";
            this.btnBuscarXdesc.Size = new System.Drawing.Size(179, 23);
            this.btnBuscarXdesc.TabIndex = 9;
            this.btnBuscarXdesc.Text = "buscar";
            this.btnBuscarXdesc.UseVisualStyleBackColor = true;
            this.btnBuscarXdesc.Click += new System.EventHandler(this.btnBuscarXdesc_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 31);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Buscar articulos por criterio";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(22, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(148, 15);
            this.lblSubtitulo.TabIndex = 11;
            this.lblSubtitulo.Text = "Buscar por solo un criterio";
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 454);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBuscarXdesc);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblBuscarXdesc);
            this.Controls.Add(this.btnBuscarXnombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblBuscarXnombre);
            this.Controls.Add(this.dgvBuscarArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.lblIngresarCodigo);
            this.MinimumSize = new System.Drawing.Size(992, 347);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar articulo por codigo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBuscarArticulo;
        private System.Windows.Forms.Label lblBuscarXnombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnBuscarXnombre;
        private System.Windows.Forms.Label lblBuscarXdesc;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Button btnBuscarXdesc;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}