namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Socios
    {
        public Socios()
        {
            Vehiculos = new HashSet<Vehiculos>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Codigo Socio")]
        public string CodigoSocio { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Primer Apellido")]
        public string Apellido1Socio { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Segundo Apellido")]
        public string Apellido2Socio { get; set; }

        public bool Estado { get; set; }

        public virtual ICollection<Vehiculos> Vehiculos { get; set; }

        [NotMapped]
        public string SocioNombre
        {
            get
            {
                return this.CodigoSocio + " " + this.Nombres + " " + this.Apellido1Socio;
            }
        }
        public override string ToString()
        {
            return this.Nombres + " " + this.Apellido1Socio;
        }
    }
}
