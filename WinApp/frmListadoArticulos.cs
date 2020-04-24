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
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                CboCategorias.DataSource = categoriaNegocio.listar();
                CboCategorias.ValueMember = "Id";
                CboCategorias.DisplayMember = "Nombre";
                CboCategorias.SelectedIndex = -1;

                CboMarcas.DataSource = marcaNegocio.listar();
                CboMarcas.ValueMember = "Id";
                CboMarcas.DisplayMember = "Nombre";
                CboMarcas.SelectedIndex = -1;

                cargarDatos();

            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            string campo = cboCampos.SelectedItem.ToString();
            try
            {
                
                if (txtBuscar.Text == "" || txtBuscar.Text.Length <=3)
                {
                    listaFiltrada = lista;
                    dgvArticulos.DataSource = listaFiltrada;

                }
                if (campo == "Codigo")
                {
                    listaFiltrada = lista.FindAll(k => k.Codigo.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Nombre" && txtBuscar.Text.Length > 3)
                {
                    listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Descripcion" && txtBuscar.Text.Length > 3 )
                {
                    listaFiltrada = lista.FindAll(k => k.Descripcion.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                //dgvArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampos.SelectedItem.ToString();
            if(campo == "Codigo")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Location = new Point(176, 47);
                CboMarcas.Visible = false;
                CboCategorias.Visible = false;
                txtBuscar.Focus();
            }
            if (campo == "Nombre")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Location = new Point(176, 47);
                CboMarcas.Visible = false;
                CboCategorias.Visible = false;
                txtBuscar.Focus();
            }
            if (campo == "Descripcion")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Location = new Point(176, 47);
                CboMarcas.Visible = false;
                CboCategorias.Visible = false;
                txtBuscar.Focus();
            }
            if (campo == "Categoria")
            {
                cargarDatos();
                CboCategorias.Visible = true;
                CboCategorias.Location = new Point(176, 47);
                CboMarcas.Visible = false;
                txtBuscar.Visible = false;
            }
            if (campo == "Marca")
            {
                cargarDatos();
                CboMarcas.Visible = true;
                CboMarcas.Location=new Point(176, 47);
                CboCategorias.Visible = false;
                txtBuscar.Visible = false;
            }
        }

        private void CboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboMarcas.Visible == true)
            {
                int id = CboMarcas.SelectedIndex + 1;
                string campo = CboMarcas.SelectedItem.ToString();

                ArticuloNegocio negocio = new ArticuloNegocio();

                try
                {
                    lista = negocio.listarByFilters(campo, id);
                    dgvArticulos.DataSource = lista;
                    dgvArticulos.Columns[0].Visible = false;
                    dgvArticulos.Columns[6].Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                cargarDatos();
            }
        }

        private void CboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCategorias.Visible == true)
            {
                int id = CboCategorias.SelectedIndex;
                string campo = CboCategorias.SelectedItem.ToString();

                ArticuloNegocio negocio = new ArticuloNegocio();

                try
                {
                    lista = negocio.listarByFilters(campo, id);
                    dgvArticulos.DataSource = lista;
                    dgvArticulos.Columns[0].Visible = false;
                    dgvArticulos.Columns[6].Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                cargarDatos();
            }
        }
    }
}
