namespace winform_app
{
    partial class frmEditarArticulo
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
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.pbImagenArt = new System.Windows.Forms.PictureBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodArt = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodArticulo = new System.Windows.Forms.Label();
            this.cbUrlImagenes = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAgregarImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(92, 127);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(129, 20);
            this.tbPrecio.TabIndex = 66;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(20, 129);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 67;
            this.labelPrecio.Text = "Precio";
            // 
            // pbImagenArt
            // 
            this.pbImagenArt.Location = new System.Drawing.Point(308, 58);
            this.pbImagenArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagenArt.Name = "pbImagenArt";
            this.pbImagenArt.Size = new System.Drawing.Size(182, 163);
            this.pbImagenArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenArt.TabIndex = 65;
            this.pbImagenArt.TabStop = false;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(20, 203);
            this.labelUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(56, 13);
            this.labelUrlImagen.TabIndex = 64;
            this.labelUrlImagen.Text = "Imagenes:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(92, 175);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(129, 21);
            this.cbCategoria.TabIndex = 59;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(92, 151);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(129, 21);
            this.cbMarca.TabIndex = 58;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(20, 178);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 63;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(20, 153);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 62;
            this.labelMarca.Text = "Marca:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(157, 289);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(64, 27);
            this.buttonCancelar.TabIndex = 61;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(38, 289);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(64, 27);
            this.buttonAceptar.TabIndex = 60;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(92, 103);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(129, 20);
            this.tbDescripcion.TabIndex = 55;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(92, 80);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(129, 20);
            this.tbNombre.TabIndex = 53;
            // 
            // tbCodArt
            // 
            this.tbCodArt.Location = new System.Drawing.Point(92, 58);
            this.tbCodArt.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodArt.Name = "tbCodArt";
            this.tbCodArt.Size = new System.Drawing.Size(129, 20);
            this.tbCodArt.TabIndex = 51;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(20, 107);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 56;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 85);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 54;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelCodArticulo
            // 
            this.labelCodArticulo.AutoSize = true;
            this.labelCodArticulo.Location = new System.Drawing.Point(20, 62);
            this.labelCodArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodArticulo.Name = "labelCodArticulo";
            this.labelCodArticulo.Size = new System.Drawing.Size(43, 13);
            this.labelCodArticulo.TabIndex = 52;
            this.labelCodArticulo.Text = "Codigo:";
            // 
            // cbUrlImagenes
            // 
            this.cbUrlImagenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrlImagenes.FormattingEnabled = true;
            this.cbUrlImagenes.Location = new System.Drawing.Point(92, 200);
            this.cbUrlImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.cbUrlImagenes.Name = "cbUrlImagenes";
            this.cbUrlImagenes.Size = new System.Drawing.Size(129, 21);
            this.cbUrlImagenes.TabIndex = 68;
            this.cbUrlImagenes.SelectedIndexChanged += new System.EventHandler(this.cbUrlImagenes_SelectedIndexChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(226, 228);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(61, 23);
            this.btAgregar.TabIndex = 69;
            this.btAgregar.Text = "Agregar imagen";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(226, 198);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(61, 23);
            this.btEliminar.TabIndex = 70;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Url Imagen:";
            // 
            // tbAgregarImagen
            // 
            this.tbAgregarImagen.Location = new System.Drawing.Point(92, 228);
            this.tbAgregarImagen.Name = "tbAgregarImagen";
            this.tbAgregarImagen.Size = new System.Drawing.Size(129, 20);
            this.tbAgregarImagen.TabIndex = 72;
            // 
            // frmEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 352);
            this.Controls.Add(this.tbAgregarImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbUrlImagenes);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.pbImagenArt);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodArt);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodArticulo);
            this.Name = "frmEditarArticulo";
            this.Text = "frmEditarArticulo";
            this.Load += new System.EventHandler(this.frmEditarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox pbImagenArt;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodArt;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodArticulo;
        private System.Windows.Forms.ComboBox cbUrlImagenes;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAgregarImagen;
    }
}