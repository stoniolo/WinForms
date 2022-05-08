namespace WindowsFormsTP
{
    partial class fmDetalles
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(161, 337);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(196, 57);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lNombre.Location = new System.Drawing.Point(210, 9);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(62, 16);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(27, 108);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(46, 13);
            this.lCodigo.TabIndex = 2;
            this.lCodigo.Text = "Código: ";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(27, 69);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(24, 13);
            this.lId.TabIndex = 3;
            this.lId.Text = "ID: ";
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(282, 41);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(212, 194);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 4;
            this.pbArticulo.TabStop = false;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(27, 151);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(60, 13);
            this.lCategoria.TabIndex = 5;
            this.lCategoria.Text = "Categoría: ";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(27, 198);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(43, 13);
            this.lMarca.TabIndex = 6;
            this.lMarca.Text = "Marca: ";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(27, 293);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lDescripcion.TabIndex = 7;
            this.lDescripcion.Text = "Descripción: ";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(371, 238);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 8;
            this.lPrecio.Text = "Precio";
            // 
            // fmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 411);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bCerrar);
            this.Name = "fmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmDetalles";
            this.Load += new System.EventHandler(this.fmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lPrecio;
    }
}