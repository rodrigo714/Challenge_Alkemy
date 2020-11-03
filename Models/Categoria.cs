using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Alkemy.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public IEnumerable<Posts> Posts { get; set; }
    }
}