using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace WindowsFormsTP
{
    public partial class fmAgregar : Form
    {
        private OpenFileDialog archivo = null;

        private string direccionCopia = null;
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
                art.Categoria = (Categoria)cbCategoria.SelectedItem;
                art.Marca = (Marca)cbMarca.SelectedItem;
                art.Precio = decimal.Parse(tbPrecio.Text);
                art.Descripcion = rtbDescripcion.Text;
                art.ImagenURL = tbImagen.Text;
                negocio.agregar(art);

                if(archivo != null && !(tbImagen.Text.ToUpper().Contains("HTTP")))
                {
                    crearDirectorioCatalogo();
                    File.Copy(archivo.FileName, direccionCopia);
                }

                MessageBox.Show("Agregado correctamente");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cargarImagen("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            try
            {
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string filename)
        {
            try
            {
                pbxAgregarArticulo.Load(filename);
            }
            catch (Exception)
            {
                pbxAgregarArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
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
