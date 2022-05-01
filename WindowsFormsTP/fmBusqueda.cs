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
    
    public partial class fmBusqueda : Form
    {
        private List<Articulo> listaArticulos;
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
            listaArticulos = negocio.listar();
            dgvBusqueda.DataSource = listaArticulos;
            pbArticulo.Load(listaArticulos[0].ImagenURL);
            
        }

        private void dgvBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selected = (Articulo)dgvBusqueda.CurrentRow.DataBoundItem;
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
    }
}
