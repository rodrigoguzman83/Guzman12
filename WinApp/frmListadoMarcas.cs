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
    public partial class frmListadoMarcas : Form
    {
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                dgvMarcas.DataSource = negocio.listar();
                dgvMarcas.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
