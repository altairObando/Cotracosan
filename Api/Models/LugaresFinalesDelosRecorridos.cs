namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LugaresFinalesDelosRecorridos
    {
        public LugaresFinalesDelosRecorridos()
        {
            Carreras = new HashSet<Carreras>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        [Display(Name = "Codigo")]
        public string CodigoDeLugar { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string NombreDeLugar { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Carreras> Carreras { get; set; }
    }
}
