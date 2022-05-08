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
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            pbArticulo.Load(listaArticulos[0].ImagenURL);
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenURL"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            pbArticulo.Load(listaArticulos[0].ImagenURL);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo selected = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(selected.ImagenURL);
            }
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

        private void txtFiltroRapido_KeyUp(object sender, KeyEventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 2) listaFiltrada = listaArticulos.FindAll(articulo => articulo.Nombre.ToUpper().Contains(filtro.ToUpper()));
            else listaFiltrada = listaArticulos;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCriterio.Items.Clear();
            if(cboCampo.SelectedItem != null)
            {
                string opcion = cboCampo.SelectedItem.ToString();
                if(opcion == "Precio")
                {
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                }
                else
                {
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio ();
            if (cboCampo.SelectedItem != null && cboCriterio.SelectedItem != null)
            {
                try
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        }

        private void bLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtFiltroRapido.Text = "";
            txtFiltro.Text = "";
            cboCriterio.SelectedIndex = -1;
            cboCampo.SelectedIndex = -1;
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmAgregar))
                    return;
            }

            fmAgregar fmAgregar = new fmAgregar();
            fmAgregar.ShowDialog();
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
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
            cargar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmAgregar))
                    return;
            }

            fmAgregar fmAgregar = new fmAgregar();
            fmAgregar.ShowDialog();
            cargar();
        }

        private void bDetalle_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(fmDetalles))
                    return;
            }

            fmDetalles fmDetalles = new fmDetalles((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
            fmDetalles.ShowDialog();
            cargar();
        }
    }
}
