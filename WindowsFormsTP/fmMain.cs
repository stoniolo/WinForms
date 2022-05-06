using System;
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
    public partial class mainForm : Form
    {
        private List<Articulo> listaArticulos;
        public mainForm()
        {
            InitializeComponent();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmBusqueda))
                    return;
            }

            fmBusqueda fmBusqueda = new fmBusqueda();
            fmBusqueda.MdiParent = this;
            fmBusqueda.Show();
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmBusqueda))
                    return;
            }

            fmBusqueda fmBusqueda = new fmBusqueda();
            fmBusqueda.MdiParent = this;
            fmBusqueda.Show();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmAgregar))
                    return;
            }

            fmAgregar fmAgregar = new fmAgregar();
            fmAgregar.ShowDialog();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmModificar))
                    return;
            }
            Articulo selected = new Articulo();
            selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            fmModificar fmModificar = new fmModificar(selected);
            fmModificar.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            /*foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmBusqueda))
                    return;
            }

            fmBusqueda fmBusqueda = new fmBusqueda();
            fmBusqueda.MdiParent = this;
            fmBusqueda.Show();*/
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["ImagenURL"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            pbArticulo.Load(listaArticulos[0].ImagenURL);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selected = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(selected.ImagenURL);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
