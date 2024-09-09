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
            this.MenuLisatado = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menorAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayorAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLisatado,
            this.busquedaDeArticulosToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(960, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // MenuLisatado
            // 
            this.MenuLisatado.Name = "MenuLisatado";
            this.MenuLisatado.Size = new System.Drawing.Size(123, 20);
            this.MenuLisatado.Text = "Listado de Articulos";
            this.MenuLisatado.Click += new System.EventHandler(this.MenuLisatado_Click);
            // 
            // busquedaDeArticulosToolStripMenuItem
            // 
            this.busquedaDeArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnCodigo,
            this.categoriaToolStripMenuItem,
            this.descripcionToolStripMenuItem,
            this.marcaToolStripMenuItem1,
            this.categoriaToolStripMenuItem1,
            this.preciosToolStripMenuItem});
            this.busquedaDeArticulosToolStripMenuItem.Name = "busquedaDeArticulosToolStripMenuItem";
            this.busquedaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.busquedaDeArticulosToolStripMenuItem.Text = "Busqueda de Articulos";
            // 
            // SubMnCodigo
            // 
            this.SubMnCodigo.Name = "SubMnCodigo";
            this.SubMnCodigo.Size = new System.Drawing.Size(180, 22);
            this.SubMnCodigo.Text = "Codigo";
            this.SubMnCodigo.Click += new System.EventHandler(this.SubMnCodigo_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Nombre";
            // 
            // descripcionToolStripMenuItem
            // 
            this.descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            this.descripcionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descripcionToolStripMenuItem.Text = "Descripcion";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menorAToolStripMenuItem,
            this.mayorAToolStripMenuItem});
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preciosToolStripMenuItem.Text = "Precios";
            // 
            // menorAToolStripMenuItem
            // 
            this.menorAToolStripMenuItem.Name = "menorAToolStripMenuItem";
            this.menorAToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.menorAToolStripMenuItem.Text = "Menor a";
            // 
            // mayorAToolStripMenuItem
            // 
            this.mayorAToolStripMenuItem.Name = "mayorAToolStripMenuItem";
            this.mayorAToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.mayorAToolStripMenuItem.Text = "Mayor a";
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
        private System.Windows.Forms.ToolStripMenuItem SubMnCodigo;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menorAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayorAToolStripMenuItem;
    }
}