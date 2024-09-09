namespace winform_app
{
    partial class frmBuscarXnombre
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.dgvBuscarXnombre = new System.Windows.Forms.DataGridView();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarXnombre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "ingresar nombre: ";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Location = new System.Drawing.Point(121, 9);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(279, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // dgvBuscarXnombre
            // 
            this.dgvBuscarXnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarXnombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarXnombre.Location = new System.Drawing.Point(30, 38);
            this.dgvBuscarXnombre.Name = "dgvBuscarXnombre";
            this.dgvBuscarXnombre.Size = new System.Drawing.Size(462, 150);
            this.dgvBuscarXnombre.TabIndex = 2;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNombre.Location = new System.Drawing.Point(407, 9);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarNombre.TabIndex = 3;
            this.btnBuscarNombre.Text = "buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // frmBuscarXnombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 279);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.dgvBuscarXnombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximumSize = new System.Drawing.Size(1329, 703);
            this.MinimumSize = new System.Drawing.Size(657, 318);
            this.Name = "frmBuscarXnombre";
            this.Text = "buscar por nombre de articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarXnombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.DataGridView dgvBuscarXnombre;
        private System.Windows.Forms.Button btnBuscarNombre;
    }
}