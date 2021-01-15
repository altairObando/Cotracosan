namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Articulos
    {
        public Articulos()
        {
            DetallesDeCreditos = new HashSet<DetallesDeCreditos>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        [Display(Name ="Codigo Articulo")]
        public string CodigoDeArticulo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Descripción")]
        public string DescripcionDeArticulo { get; set; }

        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<DetallesDeCreditos> DetallesDeCreditos { get; set; }
    }
}
