namespace winform_app
{
    partial class frmPrincipal
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.MenuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarCategoría = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarCategoría = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarCategoría = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListado,
            this.busquedaDeArticulosToolStripMenuItem,
            this.administrarArticulosToolStripMenuItem,
            this.administrarMarcasToolStripMenuItem,
            this.administrarCategoríasToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(960, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // MenuListado
            // 
            this.MenuListado.Name = "MenuListado";
            this.MenuListado.Size = new System.Drawing.Size(123, 20);
            this.MenuListado.Text = "Listado de Articulos";
            this.MenuListado.Click += new System.EventHandler(this.MenuListado_Click);
            // 
            // busquedaDeArticulosToolStripMenuItem
            // 
            this.busquedaDeArticulosToolStripMenuItem.Name = "busquedaDeArticulosToolStripMenuItem";
            this.busquedaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.busquedaDeArticulosToolStripMenuItem.Text = "Busqueda de Articulos";
            this.busquedaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeArticulosToolStripMenuItem_Click);
            // 
            // administrarArticulosToolStripMenuItem
            // 
            this.administrarArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem});
            this.administrarArticulosToolStripMenuItem.Name = "administrarArticulosToolStripMenuItem";
            this.administrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.administrarArticulosToolStripMenuItem.Text = "Administrar Artículos";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Artículo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarMarca,
            this.btnModificarMarca,
            this.btnEliminarMarca});
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar Marcas";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(180, 22);
            this.btnModificarMarca.Text = "Modificar Marca";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(180, 22);
            this.btnEliminarMarca.Text = "Eliminar Marca";
            // 
            // administrarCategoríasToolStripMenuItem
            // 
            this.administrarCategoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarCategoría,
            this.btnModificarCategoría,
            this.btnEliminarCategoría});
            this.administrarCategoríasToolStripMenuItem.Name = "administrarCategoríasToolStripMenuItem";
            this.administrarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.administrarCategoríasToolStripMenuItem.Text = "Administrar Categorías";
            // 
            // btnAgregarCategoría
            // 
            this.btnAgregarCategoría.Name = "btnAgregarCategoría";
            this.btnAgregarCategoría.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarCategoría.Text = "Agregar Categoría";
            // 
            // btnModificarCategoría
            // 
            this.btnModificarCategoría.Name = "btnModificarCategoría";
            this.btnModificarCategoría.Size = new System.Drawing.Size(180, 22);
            this.btnModificarCategoría.Text = "Modificar Categoría";
            // 
            // btnEliminarCategoría
            // 
            this.btnEliminarCategoría.Name = "btnEliminarCategoría";
            this.btnEliminarCategoría.Size = new System.Drawing.Size(180, 22);
            this.btnEliminarCategoría.Text = "Eliminar Categoría";
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(960, 324);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRADOR DE ARTICULOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuListado;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lISTADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dETALLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem MenuLisatado;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem btnModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem administrarCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarCategoría;
        private System.Windows.Forms.ToolStripMenuItem btnModificarCategoría;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarCategoría;
    }
}