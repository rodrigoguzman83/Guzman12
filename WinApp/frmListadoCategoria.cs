using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WinApp
{
    public partial class frmListadoCategoria : Form
    {
        public frmListadoCategoria()
        {
            InitializeComponent();
        }

        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                dgvCategorias.DataSource = negocio.listar();
                dgvCategorias.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
