namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nominas
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo de nomina")]
        public string Id_nomina { get; set; }

        [Required]
        [StringLength(30)]
        public string Año { get; set; }

        [Required]
        [StringLength(30)]
        public string Mes { get; set; }

        [Required]
        [Display(Name = "Monto total")]
        public decimal? MontoTotal { get; set; }
    }
}
