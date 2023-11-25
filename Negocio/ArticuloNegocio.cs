using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDataBase;
namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDataBase.AccesoDatos datos;
        public ArticuloNegocio()
        {
            datos= new AccesoDatos();
        }
        public List<Articulo> ListarArticulos()
        {
            List <Articulo> lista= new List <Articulo>();
            try
            {
                datos.SetearConsulta("select Id,Codigo,Nombre,Descripcion,ImagenUrl,Precio from ARTICULOS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo auxiliar= new Articulo();
                    auxiliar.IdArticulo = (int)datos.Lector["Id"];
                    auxiliar.CodigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.NombreArticulo = (string)datos.Lector["Nombre"];
                    auxiliar.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    auxiliar.UrlImagenArticulo = (string)datos.Lector["ImagenUrl"];
                    auxiliar.PrecioArticulo = (decimal)datos.Lector["Precio"];

                    lista.Add(auxiliar);

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
    }
}
