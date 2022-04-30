namespace WindowsFormsTP
{
    partial class fmBusqueda
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
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.bCerrarForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(14, 12);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(738, 360);
            this.dgvBusqueda.TabIndex = 0;
            // 
            // bCerrarForm
            // 
            this.bCerrarForm.Location = new System.Drawing.Point(677, 378);
            this.bCerrarForm.Name = "bCerrarForm";
            this.bCerrarForm.Size = new System.Drawing.Size(75, 23);
            this.bCerrarForm.TabIndex = 1;
            this.bCerrarForm.Text = "Cerrar";
            this.bCerrarForm.UseVisualStyleBackColor = true;
            this.bCerrarForm.Click += new System.EventHandler(this.bCerrarForm_Click);
            // 
            // fmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 413);
            this.ControlBox = false;
            this.Controls.Add(this.bCerrarForm);
            this.Controls.Add(this.dgvBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "fmBusqueda";
            this.ShowInTaskbar = false;
            this.Text = "fmBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Button bCerrarForm;
    }
}