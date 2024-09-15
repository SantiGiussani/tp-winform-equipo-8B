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
            this.administrarArticulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminFamiliasToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdminMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdminCategorías = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListado,
            this.busquedaDeArticulosToolStripMenuItem,
            this.administrarArticulosToolStripMenuItem,
            this.AdminFamiliasToolStrip});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(904, 24);
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
            this.agregarArticuloToolStripMenuItem,
            this.administrarArticulosToolStripMenuItem1});
            this.administrarArticulosToolStripMenuItem.Name = "administrarArticulosToolStripMenuItem";
            this.administrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.administrarArticulosToolStripMenuItem.Text = "Administrar Artículos";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Artículo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // administrarArticulosToolStripMenuItem1
            // 
            this.administrarArticulosToolStripMenuItem1.Name = "administrarArticulosToolStripMenuItem1";
            this.administrarArticulosToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.administrarArticulosToolStripMenuItem1.Text = "Administrar Articulos";
            this.administrarArticulosToolStripMenuItem1.Click += new System.EventHandler(this.administrarArticulosToolStripMenuItem1_Click);
            // 
            // AdminFamiliasToolStrip
            // 
            this.AdminFamiliasToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdminMarcas,
            this.btnAdminCategorías});
            this.AdminFamiliasToolStrip.Name = "AdminFamiliasToolStrip";
            this.AdminFamiliasToolStrip.Size = new System.Drawing.Size(127, 20);
            this.AdminFamiliasToolStrip.Text = "Administrar Familias";
            // 
            // btnAdminMarcas
            // 
            this.btnAdminMarcas.Name = "btnAdminMarcas";
            this.btnAdminMarcas.Size = new System.Drawing.Size(130, 22);
            this.btnAdminMarcas.Text = "Marcas";
            this.btnAdminMarcas.Click += new System.EventHandler(this.btnAdminMarcas_Click);
            // 
            // btnAdminCategorías
            // 
            this.btnAdminCategorías.Name = "btnAdminCategorías";
            this.btnAdminCategorías.Size = new System.Drawing.Size(130, 22);
            this.btnAdminCategorías.Text = "Categorías";
            this.btnAdminCategorías.Click += new System.EventHandler(this.btnAdminCategorías_Click);
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip3;
            this.MinimumSize = new System.Drawing.Size(920, 500);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
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
        private System.Windows.Forms.ToolStripMenuItem administrarArticulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AdminFamiliasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnAdminMarcas;
        private System.Windows.Forms.ToolStripMenuItem btnAdminCategorías;
    }
}