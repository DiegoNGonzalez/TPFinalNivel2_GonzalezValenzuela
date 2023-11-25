using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using AccesoDataBase;

namespace TpFinal
{
    public partial class FormCatalogo : Form
    {
        private List<Articulo> ListaArticulo;
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo= negocio.ListarArticulos();
            dgvArticulos.DataSource= ListaArticulo;
            dgvArticulos.Columns["UrlImagenArticulo"].Visible=false;
            CargarImagen(ListaArticulo[0].UrlImagenArticulo);
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.UrlImagenArticulo);

            }
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxArticulo.Load(imagen);

            }
            catch (Exception ex)
            {

                picBoxArticulo.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
            }
        }
    }
}
