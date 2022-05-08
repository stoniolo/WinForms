using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

        private OpenFileDialog archivo = null;

        private string direccionCopia = null;
        public fmModificar()
        {
            InitializeComponent();
        }

        public fmModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void cargarImagen(string filename)
        {
            try
            {
                pbxModificarArticulo.Load(filename);
            }
            catch (Exception)
            {
                pbxModificarArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
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
                    cargarImagen(articulo.ImagenURL);
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

                if (archivo != null && !(tbImagen.Text.ToUpper().Contains("HTTP")))
                {
                    crearDirectorioCatalogo();
                    File.Copy(archivo.FileName, direccionCopia);
                }

                negocio.modificar(articulo);
                MessageBox.Show("Modificado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void crearDirectorioCatalogo()
        {
            try
            {
                if (!(Directory.Exists(ConfigurationManager.AppSettings["images-folder"])))
                {
                    DirectoryInfo di = Directory.CreateDirectory(ConfigurationManager.AppSettings["images-folder"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                cargarImagen(archivo.FileName);
                DateTime date = DateTime.Now;
                direccionCopia = ConfigurationManager.AppSettings["images-folder"] + date.ToString("dd-MM-yy-HH-mm-ss-") + archivo.SafeFileName;
                tbImagen.Text = direccionCopia;
            }
        }

        private void tbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImagen.Text);
        }
    }
}
