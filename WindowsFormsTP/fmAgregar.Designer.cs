namespace WindowsFormsTP
{
    partial class fmAgregar
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
            this.bAgregarArt = new System.Windows.Forms.Button();
            this.bCerrarAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAgregarArt
            // 
            this.bAgregarArt.Location = new System.Drawing.Point(379, 190);
            this.bAgregarArt.Name = "bAgregarArt";
            this.bAgregarArt.Size = new System.Drawing.Size(102, 35);
            this.bAgregarArt.TabIndex = 0;
            this.bAgregarArt.Text = "Agregar";
            this.bAgregarArt.UseVisualStyleBackColor = true;
            this.bAgregarArt.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCerrarAgregar
            // 
            this.bCerrarAgregar.Location = new System.Drawing.Point(231, 190);
            this.bCerrarAgregar.Name = "bCerrarAgregar";
            this.bCerrarAgregar.Size = new System.Drawing.Size(102, 35);
            this.bCerrarAgregar.TabIndex = 1;
            this.bCerrarAgregar.Text = "Cerrar";
            this.bCerrarAgregar.UseVisualStyleBackColor = true;
            this.bCerrarAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 237);
            this.Controls.Add(this.bCerrarAgregar);
            this.Controls.Add(this.bAgregarArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmAgregar";
            this.ShowInTaskbar = false;
            this.Text = "Agregar Articulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAgregarArt;
        private System.Windows.Forms.Button bCerrarAgregar;
    }
}