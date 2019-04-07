namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Licencias
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo de licencia")]
        public string Id_licencia { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Correo del usuario")]
        public string Id_empleado { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Desde { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Hasta { get; set; }

        [Required]
        [StringLength(30)]
        public string Motivo { get; set; }

        [StringLength(150)]
        public string Comentario { get; set; }

        public virtual Empleados Empleados { get; set; }
    }
}
