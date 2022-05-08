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
    public partial class fmDetalles : Form
    {
        public Articulo art;

        public fmDetalles(Articulo art)
        {
            InitializeComponent();
            this.art = art;
            this.Text = art.Nombre;
        }

        private void fmDetalles_Load(object sender, EventArgs e)
        {
            lCodigo.Text = "Codigo de articulo: " + art.Codigo;
            lNombre.Text = art.Nombre;
            lId.Text = "Id del articulo: " + art.Id;
            lCategoria.Text = "Categoria: " + art.Categoria.Descripcion;
            lMarca.Text = "Marca: " + art.Marca.Descripcion;
            lPrecio.Text = art.Precio.ToString();
            lDescripcion.Text = "Descripcion: " + art.Descripcion;

            string imagen = art.ImagenURL;
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lNombre_Click(object sender, EventArgs e)
        {

        }

        private void lPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
