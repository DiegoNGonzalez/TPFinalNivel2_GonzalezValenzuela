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
        private ArticuloNegocio negocio;
        public FormCatalogo()
        {
            InitializeComponent();
            negocio = new ArticuloNegocio();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarGrid()
        {
            try
            {
                ListaArticulo = negocio.ListarArticulos();
                dgvArticulos.DataSource = ListaArticulo;
                dgvArticulos.Columns["UrlImagenArticulo"].Visible = false;
                dgvArticulos.Columns["IdArticulo"].Visible = false;
                dgvArticulos.Columns["PrecioArticulo"].DefaultCellStyle.Format = "0.00";
                CargarImagen(ListaArticulo[0].UrlImagenArticulo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su dev "+ex.ToString());
            }
            
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormAgregar modificar= new FormAgregar(seleccionado);
            modificar.ShowDialog();
            CargarGrid();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Articulo seleccionado;
            string mensaje, titulo;
            mensaje = "Esta seguro que desea eliminar el articulo ";
            titulo = "Eliminando Articulo";
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta=MessageBox.Show(mensaje+seleccionado.NombreArticulo+" ?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.EliminarArticulo(seleccionado.IdArticulo);
                    MessageBox.Show("Eliminado Correctamente");
                }
                CargarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. "+ ex.ToString());
            }

        }
    }
}
