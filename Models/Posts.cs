using Challenge_Alkemy.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Challenge_Alkemy.Models
{
    public class Posts : ISoftDeleted
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Contenido { get; set; }

        public byte[] Imagen { get; set; }

        public int Categoria { get; set; }

        [Display(Name ="Fecha Creacion")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Fecha_Creacion { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}