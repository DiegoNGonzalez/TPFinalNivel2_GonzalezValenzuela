using Dominio;
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
    public partial class FormVerDetalle : Form
    {
        public FormVerDetalle()
        {
            InitializeComponent();
        }
        public FormVerDetalle(Articulo artiDetalle)
        {
            InitializeComponent();
            CargarImagen(artiDetalle.UrlImagenArticulo);
            txtNombre.Text = artiDetalle.NombreArticulo;
            txtDescripcion.Text = artiDetalle.DescripcionArticulo;
            txtPrecio.Text = artiDetalle.PrecioArticulo.ToString("0.00");
            txtCategoria.Text = artiDetalle.CategoriaArticulo.DescripcionCategoria;
            txtMarca.Text = artiDetalle.MarcaArticulo.DescripcionMarca;
            txtCodigo.Text = artiDetalle.CodigoArticulo;

        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxDetalle.Load(imagen);

            }
            catch (Exception ex)
            {

                picBoxDetalle.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
            }
        }
    }
}
