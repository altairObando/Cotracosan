namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DetallesDeCreditos
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        [Display(Name = "Credito")]
        public int CreditoId { get; set; }
        [Display(Name = "Articulo")]
        public int ArticuloId { get; set; }

        public virtual Articulos Articulos { get; set; }

        public virtual Creditos Creditos { get; set; }
    }
}
