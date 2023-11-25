using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        [DisplayName ("Id")]
        public int IdArticulo { get; set; }
        [DisplayName ("Codigo")]
        public string CodigoArticulo {  get; set; }
        [DisplayName ("Nombre")]
        public string NombreArticulo { get; set; }
        [DisplayName ("Descripción")]
        public string DescripcionArticulo { get; set; }
        [DisplayName("Marca")]
        public Marca MarcaArticulo { get; set; }
        [DisplayName ("Categoria")]
        public Categoria CategoriaArticulo { get; set; }
        public string UrlImagenArticulo { get; set; }
        [DisplayName ("Precio")]
        public decimal PrecioArticulo { get; set; }
        

    }
}
