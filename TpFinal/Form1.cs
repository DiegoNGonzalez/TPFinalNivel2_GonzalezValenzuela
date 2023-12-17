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
using Microsoft.Win32;

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
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Codigo");
            cboxCampo.Items.Add("Marca");
            cboxCampo.Items.Add("Categoria");
            cboxCampo.Items.Add("Precio");
        }
        private void CargarGrid()
        {
            try
            {
                ListaArticulo = negocio.ListarArticulos();
                dgvArticulos.DataSource = ListaArticulo;
                dgvArticulos.Columns["UrlImagenArticulo"].Visible = false;
                dgvArticulos.Columns["IdArticulo"].Visible = false;
                dgvArticulos.Columns["PrecioArticulo"].DefaultCellStyle.Format = "$0.00";
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

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionadoDetalle;
            try
            {
                seleccionadoDetalle = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormVerDetalle detalle = new FormVerDetalle(seleccionadoDetalle);
                detalle.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. "+ex.ToString());
            }
        }
        private bool ValidarFiltro()
        {
            if (cboxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para filtrar.");
                return true;
            }
            if (cboxCampo.SelectedIndex == 0 && txtFiltro.Text == "")
            {
                MessageBox.Show("Por favor ingrese un numero para filtrar");
                return true;
            }
            if (cboxCampo.SelectedIndex == 4 && txtFiltro.Text.Length > 0)
            {
                if (!(SoloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Solo puede ingresar numeros segun el campo y criterio elegido, reingrese el dato.");
                    return true;
                }
            }

            return false;
        }
        private bool SoloNumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!(char.IsNumber(c)))
                    return false;
            }
            return true;
        }
        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCampo.SelectedIndex != -1)
            {

            string opcion = cboxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cBoxCriterio.Items.Clear();
                cBoxCriterio.Items.Add("Mayor a ");
                cBoxCriterio.Items.Add("Menor a ");
                cBoxCriterio.Items.Add("Igual a ");
            }
            else
            {
                cBoxCriterio.Items.Clear();
                cBoxCriterio.Items.Add("Comienza con ");
                cBoxCriterio.Items.Add("Termina con ");
                cBoxCriterio.Items.Add("Contiene ");
            }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarFiltro())
                    return;
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cBoxCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Contacte a su DEV. "+ex.ToString());
            }
            
        }

        private void txtBuscarRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscarRapido.Text;
            if(filtro.Length>2)
            {
                listaFiltrada = ListaArticulo.FindAll(X => X.NombreArticulo.ToUpper().Contains(filtro.ToUpper()) || X.CodigoArticulo.ToUpper().Contains(filtro.ToUpper()) || X.MarcaArticulo.DescripcionMarca.ToUpper().Contains(filtro.ToUpper()) || X.CategoriaArticulo.DescripcionCategoria.ToUpper().Contains(filtro.ToUpper()));
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["UrlImagenArticulo"].Visible = false;
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["PrecioArticulo"].DefaultCellStyle.Format = "$0.00";


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarRapido.Text = "";
            txtFiltro.Text = "";
            cboxCampo.SelectedIndex = -1;
            cBoxCriterio.SelectedIndex = -1;
            CargarGrid();
        }
    }
}
