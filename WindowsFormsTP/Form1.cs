using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTP
{
    public partial class mainForm : Form
    {
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
    }
}
