namespace Api.Models
{
    using Api.Utils;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Turnos
    {
        public Turnos() => Carreras = new HashSet<Carreras>();

        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        [Display (Name="Codigo de turno")]
        public string CodigoDeTurno { get; set; }
        [Display(Name = "Hora De Salida")]
        public TimeSpan HoraDeSalida { get; set; }
        [Display(Name = "Hora De Llegada")]
        public TimeSpan HoraDeLlegada { get; set; }
        public bool Estado { get; set; }
        public virtual ICollection<Carreras> Carreras { get; set; }
        [NotMapped]
        public string HorasTurno => HoraDeSalida.ToAMPM() + " - " + HoraDeLlegada.ToAMPM();
    }
}
