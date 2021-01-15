namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Vehiculos
    {
        public Vehiculos()
        {
            Carreras = new HashSet<Carreras>();
            Creditos = new HashSet<Creditos>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Placa { get; set; }
        [Display(Name = "Socio")]
        public int SocioId { get; set; }

        public bool Estado { get; set; }
        public virtual ICollection<Carreras> Carreras { get; set; }
        public virtual ICollection<Creditos> Creditos { get; set; }
        public virtual Socios Socios { get; set; }
    }
}
