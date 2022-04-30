namespace WindowsFormsTP
{
    partial class mainForm
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
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbListar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbListar,
            this.tsbBusqueda});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbBuscar});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(180, 22);
            this.tsbAgregar.Text = "Agregar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(180, 22);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbListar
            // 
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Size = new System.Drawing.Size(180, 22);
            this.tsbListar.Text = "Mostrar";
            // 
            // tsbBusqueda
            // 
            this.tsbBusqueda.Name = "tsbBusqueda";
            this.tsbBusqueda.Size = new System.Drawing.Size(180, 22);
            this.tsbBusqueda.Text = "Busqueda";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(180, 22);
            this.tsbBuscar.Text = "Buscar";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbListar;
        private System.Windows.Forms.ToolStripMenuItem tsbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsbModificar;
        private System.Windows.Forms.ToolStripMenuItem tsbEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsbBuscar;
    }
}

