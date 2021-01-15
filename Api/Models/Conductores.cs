namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Conductores
    {
        public Conductores()
        {
            Carreras = new HashSet<Carreras>();
        }
        [Display(Name ="Conductor")]
        public int Id { get; set; }

        [Required]
        [StringLength(9)]
        public string Licencia { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Primer Apellido")]
        public string Apellido1Conductor { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Segundo Apellido")]
        public string Apellido2Conductor { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Carreras> Carreras { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return this.Nombres + " " + this.Apellido1Conductor; } }
    }
}
