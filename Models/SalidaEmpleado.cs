namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalidaEmpleado")]
    public partial class SalidaEmpleado
    {
        [Key]
        [StringLength(30)]
        [Display(Name = "Codigo de salida")]
        public string Id_salidaEmpleado { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Correo del usuario")]
        public string Id_empleado { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tipo de salida")]
        public string TipoSalida { get; set; }

        [Required]
        [StringLength(150)]
        public string Motivo { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de salida")]
        public DateTime FechaSalida { get; set; }

        public virtual Empleados Empleados { get; set; }
    }
}
