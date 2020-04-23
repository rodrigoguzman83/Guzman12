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
using Dominio;

namespace WinApp
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> lista;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulo art;
                art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                picArticulo.Load(art.Imagen);
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.ShowDialog();
            cargarDatos();
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.listarNuevo();
                dgvArticulos.DataSource = lista;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmArticulo frmModificar = new frmArticulo(modificar);
            frmModificar.Text = "Modificar Articulo";
            frmModificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dgvArticulos.CurrentRow.DataBoundItem).Id;
                articuloNegocio.eliminar(id);
                cargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                if (txtBuscar.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Descripcion.ToLower().Contains(txtBuscar.Text.ToLower()));
                    //dgvArticulos.DataSource = listaFiltrada;
                }
                dgvArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
