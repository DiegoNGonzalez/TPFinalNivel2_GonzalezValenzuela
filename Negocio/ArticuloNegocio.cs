using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDataBase;
using System.Xml.Linq;

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

        public void AgregarArticulo(Articulo articulo)
        {
            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion, ImagenUrl,IdCategoria,IdMarca,Precio) values(@codigo,@Nombre,@Descripcion,@ImagenUrl,@IdCategoria,@IdMarca,@Precio)");
                datos.SetearParametro("@codigo", articulo.CodigoArticulo);
                datos.SetearParametro("@Nombre",articulo.NombreArticulo);
                datos.SetearParametro("@Descripcion", articulo.DescripcionArticulo);
                datos.SetearParametro("@ImagenUrl",articulo.UrlImagenArticulo);
                datos.SetearParametro("@IdCategoria", articulo.CategoriaArticulo.IdCategoria);
                datos.SetearParametro("@IdMarca", articulo.MarcaArticulo.IdMarca);
                datos.SetearParametro("@Precio", articulo.PrecioArticulo);
                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
        public void ModificarArticulo(Articulo modificado)
        {
            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre,Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria,ImagenUrl=@ImagenUrl,Precio=@Precio where id=@Id ");
                datos.SetearParametro("@Codigo", modificado.CodigoArticulo);
                datos.SetearParametro("@Nombre", modificado.NombreArticulo);
                datos.SetearParametro("@Descripcion", modificado.DescripcionArticulo);
                datos.SetearParametro("@ImagenUrl", modificado.UrlImagenArticulo);
                datos.SetearParametro("@IdCategoria", modificado.CategoriaArticulo.IdCategoria);
                datos.SetearParametro("@IdMarca", modificado.MarcaArticulo.IdMarca);
                datos.SetearParametro("@Precio", modificado.PrecioArticulo);
                datos.SetearParametro("@Id",modificado.IdArticulo);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
        public void EliminarArticulo(int id)
        {
            try
            {
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id="+id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = "select a.Id,Codigo,Nombre,a.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, ImagenUrl, c.id IdCategoria,m.id IdMarca,Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca=m.id and IdCategoria=c.Id AND ";
                if (campo == "Precio")
                {
                    if (criterio == "Mayor a ")
                    {
                        consulta += "Precio >" + filtro;
                    }
                    else if (criterio == "Menor a ")
                    {
                        consulta += "Precio <" + filtro;
                    }
                    else
                    {
                        consulta += "Precio = " + filtro;
                    }
                }
                else if (campo == "Nombre")
                {
                    if (criterio == "Comienza con ")
                    {
                        consulta += "Nombre like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con ")
                    {
                        consulta += "Nombre like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "Nombre like '%" + filtro + "%'";
                    }
                }
                else if (campo == "Codigo")
                {
                    if (criterio == "Comienza con ")
                    {
                        consulta += "Codigo like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con ")
                    {
                        consulta += "Codigo like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "Codigo like '%" + filtro + "%'";
                    }
                }
                else if (campo == "Marca")
                {
                    if (criterio == "Comienza con ")
                    {
                        consulta += "M.Descripcion like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con ")
                    {
                        consulta += "M.Descripcion like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "M.Descripcion like '%" + filtro + "%'";
                    }
                }
                else
                {
                    if (criterio == "Comienza con ")
                    {
                        consulta += "C.Descripcion like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con ")
                    {
                        consulta += "C.Descripcion like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "C.Descripcion like '%" + filtro + "%'";
                    }
                }


                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.UrlImagenArticulo = (string)datos.Lector["ImagenUrl"];
                    aux.MarcaArticulo = new Marca();
                    aux.MarcaArticulo.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.MarcaArticulo.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.CategoriaArticulo = new Categoria();
                    aux.CategoriaArticulo.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.CategoriaArticulo.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    aux.PrecioArticulo = (decimal)datos.Lector["Precio"];


                    lista.Add(aux);

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
