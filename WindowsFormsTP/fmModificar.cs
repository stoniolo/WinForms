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
    public partial class fmModificar : Form
    {
        private Articulo articulo = null;
        public fmModificar()
        {
            InitializeComponent();
        }

        public fmModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbPrecio.Text = articulo.Precio.ToString();
                    tbImagen.Text = articulo.ImagenURL;
                    rtbDescripcion.Text = articulo.Descripcion;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bGuardarCambios_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Descripcion = rtbDescripcion.Text;
                articulo.ImagenURL = tbImagen.Text;

                negocio.modificar(articulo);
                MessageBox.Show("Modificado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
