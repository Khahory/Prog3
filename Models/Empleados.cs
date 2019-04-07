namespace FinalProg3_prueba2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            Permisos = new HashSet<Permisos>();
            Licencias = new HashSet<Licencias>();
            SalidaEmpleado = new HashSet<SalidaEmpleado>();
            Vacaciones = new HashSet<Vacaciones>();
        }

        [Key]
        [StringLength(30)]
        [Display(Name = "Correo")]
        public string Id_empleado { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(30)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(30)]
        public string Departamento { get; set; }

        [Required]
        [StringLength(30)]
        public string Cargo { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de registro")]
        public DateTime FechaIngreso { get; set; }

        [Required]
        public decimal? Salario { get; set; }

        [Required]
        [Range(0,1)]
        public int Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permisos> Permisos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencias> Licencias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalidaEmpleado> SalidaEmpleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
    }
}
