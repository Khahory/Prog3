namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vacaciones
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo de vacacion")]
        public string Id_vacaciones { get; set; }

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
        public string Correspondiente { get; set; }

        [StringLength(150)]
        public string Comentario { get; set; }

        public virtual Empleados Empleados { get; set; }
    }
}
