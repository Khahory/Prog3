namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cargos
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo del cargo")]
        public string Id_cargo { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
    }
}
