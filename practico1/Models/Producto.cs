using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace practico1.Models
{
    public class Producto
    {

        public int ID { get; set; }
      
        public string descripcion { get; set; }
       
        public string categoria { get; set; }
        
        public decimal costo { get; set; }
    
        public decimal precioVenta { get; set; }
       
        public int existencia { get; set; }
     
        public int numPedidos { get; set; }

    }

    public class ProductoDBContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
    }
}