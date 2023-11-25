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
        private AccesoDatos datos;
        public ArticuloNegocio()
        {
            datos= new AccesoDatos();
        }
        public List<Articulo> ListarArticulos()
        {
            List <Articulo> lista= new List <Articulo>();
            try
            {
                datos.SetearConsulta("select a.Id,Codigo,Nombre,a.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, ImagenUrl, c.id IdCategoria,m.id IdMarca,Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca=m.id and IdCategoria=c.Id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo auxiliar= new Articulo();
                    auxiliar.IdArticulo = (int)datos.Lector["Id"];
                    auxiliar.CodigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.NombreArticulo = (string)datos.Lector["Nombre"];
                    auxiliar.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    auxiliar.PrecioArticulo = (decimal)datos.Lector["Precio"];
                    
                    auxiliar.UrlImagenArticulo = (string)datos.Lector["ImagenUrl"];
                    auxiliar.MarcaArticulo = new Marca();
                    auxiliar.MarcaArticulo.IdMarca= (int)datos.Lector["IdMarca"];
                    auxiliar.MarcaArticulo.DescripcionMarca = (string)datos.Lector["Marca"];
                    auxiliar.CategoriaArticulo=new Categoria();
                    auxiliar.CategoriaArticulo.IdCategoria = (int)datos.Lector["IdCategoria"];
                    auxiliar.CategoriaArticulo.DescripcionCategoria = (string)datos.Lector["Categoria"];

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
