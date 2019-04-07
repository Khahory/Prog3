namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Departamentos
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo del departamento")]
        public string Id_departamento { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Nombre del departamento")]
        public string NombreDepartamento { get; set; }
    }
}
