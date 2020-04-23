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
    public partial class frmArticulo : Form
    {
        private Articulo articulo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        //SOBREESCRIBO EL FORMULARIO DE ALTA PARA USARLO EN LA MODIFICACION
        public frmArticulo( Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            //Articulo articulo = new Articulo();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categorias = (Categoria)cboCategoria.SelectedItem;
                articulo.Marcas= (Marca)cboMarca.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = double.Parse(txtPrecio.Text);

                if(articulo.Id !=0)
                    articuloNegocio.Modificar(articulo);
                else
                    articuloNegocio.Agregar(articulo);

                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.SelectedIndex = -1;

                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Nombre";
                cboMarca.SelectedIndex = -1;

                //PARA LA MODIFICACION
                //CARGO LOS DATOS DEL OBJETO EN CADA UNO DE LOS COMPONENTES DEL FORM
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categorias.Id;
                    cboMarca.SelectedValue = articulo.Marcas.Id;
                    txtImagen.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
