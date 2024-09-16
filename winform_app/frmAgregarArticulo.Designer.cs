namespace winform_app
{
    partial class frmAgregarArticulo
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbURLImagen = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodArt = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodArt = new System.Windows.Forms.Label();
            this.pbImagenArt = new System.Windows.Forms.PictureBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(115, 100);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(99, 21);
            this.cbCategoria.TabIndex = 47;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(54, 103);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(57, 13);
            this.lbCategoria.TabIndex = 51;
            this.lbCategoria.Text = "Categoría:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(11, 329);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(80, 30);
            this.btAceptar.TabIndex = 48;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(405, 329);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(80, 30);
            this.btCancelar.TabIndex = 49;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(115, 180);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(99, 20);
            this.tbPrecio.TabIndex = 45;
            // 
            // tbURLImagen
            // 
            this.tbURLImagen.Location = new System.Drawing.Point(115, 220);
            this.tbURLImagen.Margin = new System.Windows.Forms.Padding(2);
            this.tbURLImagen.Name = "tbURLImagen";
            this.tbURLImagen.Size = new System.Drawing.Size(359, 20);
            this.tbURLImagen.TabIndex = 43;
            this.tbURLImagen.TextChanged += new System.EventHandler(this.tbURLImagen_TextChanged);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(115, 260);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(359, 49);
            this.tbDescripcion.TabIndex = 41;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(115, 60);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(99, 20);
            this.tbNombre.TabIndex = 38;
            // 
            // tbCodArt
            // 
            this.tbCodArt.Location = new System.Drawing.Point(115, 20);
            this.tbCodArt.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(99, 20);
            this.tbCodArt.TabIndex = 37;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(71, 183);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbPrecio.TabIndex = 44;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(41, 223);
            this.lbImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(70, 13);
            this.lbImagen.TabIndex = 42;
            this.lbImagen.Text = "URL Imagen:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(45, 260);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 40;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(64, 63);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 39;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodArt
            // 
            this.lbCodArt.AutoSize = true;
            this.lbCodArt.Location = new System.Drawing.Point(14, 23);
            this.lbCodArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodArt.Name = "lbCodArt";
            this.lbCodArt.Size = new System.Drawing.Size(98, 13);
            this.lbCodArt.TabIndex = 36;
            this.lbCodArt.Text = "Código de Artículo:";
            // 
            // pbImagenArt
            // 
            this.pbImagenArt.Location = new System.Drawing.Point(262, 20);
            this.pbImagenArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagenArt.Name = "pbImagenArt";
            this.pbImagenArt.Size = new System.Drawing.Size(181, 180);
            this.pbImagenArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenArt.TabIndex = 52;
            this.pbImagenArt.TabStop = false;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(115, 140);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(99, 21);
            this.cbMarca.TabIndex = 53;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(71, 143);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 54;
            this.lbMarca.Text = "Marca:";
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 370);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.pbImagenArt);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbURLImagen);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbURLImagen;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodArt;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodArt;
        private System.Windows.Forms.PictureBox pbImagenArt;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lbMarca;
    }
}