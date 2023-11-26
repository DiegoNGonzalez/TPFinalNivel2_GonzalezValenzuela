using AccesoDataBase;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpFinal
{
    public partial class FormAgregar : Form
    {
        private Articulo articulo= null;
        private AccesoDatos datos= new AccesoDatos();
        public FormAgregar()
        {
            InitializeComponent();
        }
        public FormAgregar( Articulo articulo )
        {
                InitializeComponent( );
                this.articulo = articulo;

        }
        public Articulo CapturarArticuloForm()
        {
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo=txtCodigo.Text;
                articulo.NombreArticulo=txtNombre.Text;
                articulo.DescripcionArticulo=txtDescripcion.Text;
                articulo.UrlImagenArticulo=txtUrlImg.Text;
                articulo.MarcaArticulo = (Marca)cBoxMarca.SelectedItem;
                articulo.CategoriaArticulo= (Categoria)cBoxCategoria.SelectedItem;
                articulo.PrecioArticulo = numPrecio.Value;

                return articulo;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. "+ex.ToString());
            }
            return articulo;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cBoxCategoria.DataSource = categoriaNegocio.Listar();
                cBoxCategoria.ValueMember = "IdCategoria";
                cBoxCategoria.DisplayMember = "DescripcionCategoria";
                cBoxMarca.DataSource= marcaNegocio.Listar();
                cBoxMarca.ValueMember = "IdMarca";
                cBoxMarca.DisplayMember = "DescripcionMarca";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.NombreArticulo;
                    txtDescripcion.Text = articulo.DescripcionArticulo;
                    CargarImagen(articulo.UrlImagenArticulo);
                    txtUrlImg.Text = articulo.UrlImagenArticulo;
                    cBoxMarca.SelectedValue = articulo.MarcaArticulo.IdMarca;
                    cBoxCategoria.SelectedValue = articulo.CategoriaArticulo.IdCategoria;
                    numPrecio.Value = articulo.PrecioArticulo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. " +ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = CapturarArticuloForm();
                if (articulo.IdArticulo != 0)
                {
                    articulo.CodigoArticulo = txtCodigo.Text;
                    articulo.NombreArticulo = txtNombre.Text;
                    articulo.DescripcionArticulo = txtDescripcion.Text;
                    articulo.UrlImagenArticulo = txtUrlImg.Text;
                    articulo.MarcaArticulo = (Marca)cBoxMarca.SelectedItem;
                    articulo.CategoriaArticulo = (Categoria)cBoxCategoria.SelectedItem;
                    articulo.PrecioArticulo = numPrecio.Value;
                    negocio.ModificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado con exito");
                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado con exito");

                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. "+ex.ToString());
            }
                
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                picBoxArticulo.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
                
            }
        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImg.Text);
        }
    }
}
