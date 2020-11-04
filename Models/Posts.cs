using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Challenge_Alkemy.Models
{
    public class Posts
    {
        [Key]
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public byte[] Imagen { get; set; }
        public int Categoria { get; set; }
        [Display(Name ="Fecha Creacion")]
        public DateTime Fecha_Creacion { get; set; }
    }
}