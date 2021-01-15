namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Penalizaciones
    {
        public Penalizaciones()
        {
            Carreras = new HashSet<Carreras>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string CodigoPenalizacion { get; set; }

        [Display(Name = "Valor")]
        public decimal Cantidad { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Carreras> Carreras { get; set; }
    }
}
