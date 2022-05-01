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
    public partial class fmBusqueda : Form
    {
        public fmBusqueda()
        {
            InitializeComponent();
        }

        private void bCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmBusqueda_Load(object sender, EventArgs e)
        {
            ArticuloNegocio  negocio = new ArticuloNegocio();
            dgvBusqueda.DataSource = negocio.listar();
        }
    }
}
