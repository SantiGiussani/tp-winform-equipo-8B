namespace winform_app
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFiltroRapido
            // 
            resources.ApplyResources(this.txtFiltroRapido, "txtFiltroRapido");
            this.txtFiltroRapido.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // lblFiltroRapido
            // 
            resources.ApplyResources(this.lblFiltroRapido, "lblFiltroRapido");
            this.lblFiltroRapido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            // 
            // btnAnterior
            // 
            resources.ApplyResources(this.btnAnterior, "btnAnterior");
            this.btnAnterior.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pbxImagen
            // 
            resources.ApplyResources(this.pbxImagen, "pbxImagen");
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvArticulos, "dgvArticulos");
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.CurrentCellChanged += new System.EventHandler(this.dgvArticulos_CurrentCellChanged);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblImagen
            // 
            resources.ApplyResources(this.lblImagen, "lblImagen");
            this.lblImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblImagen.Name = "lblImagen";
            // 
            // frmArticulos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmArticulos";
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblImagen;
    }
}