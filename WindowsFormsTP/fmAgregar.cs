﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsTP
{
    public partial class fmAgregar : Form
    {
        public fmAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                art.Codigo = tbCodigo.Text;
                art.Nombre = tbNombre.Text;
                art.Categoria = int.Parse(tbCategoria.Text);
                art.Marca = int.Parse(tbMarca.Text);
                art.Precio = decimal.Parse(tbPrecio.Text);
                art.Descripcion = rtbDescripcion.Text;
                art.ImagenURL = tbImagen.Text;

                negocio.agregar(art);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
