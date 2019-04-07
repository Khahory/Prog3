namespace FinalProg3_prueba2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADOContextDB_Final : DbContext
    {
        public ADOContextDB_Final()
            : base("name=ADOContextDB_Final2")
        {
        }

        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<Nominas> Nominas { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<SalidaEmpleado> SalidaEmpleado { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargos>()
                .Property(e => e.Id_cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Cargos>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Departamentos>()
                .Property(e => e.Id_departamento)
                .IsUnicode(false);

            modelBuilder.Entity<Departamentos>()
                .Property(e => e.NombreDepartamento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Id_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Departamento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .HasMany(e => e.Permisos)
                .WithRequired(e => e.Empleados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleados>()
                .HasMany(e => e.Licencias)
                .WithRequired(e => e.Empleados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleados>()
                .HasMany(e => e.SalidaEmpleado)
                .WithRequired(e => e.Empleados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleados>()
                .HasMany(e => e.Vacaciones)
                .WithRequired(e => e.Empleados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Licencias>()
                .Property(e => e.Id_licencia)
                .IsUnicode(false);

            modelBuilder.Entity<Licencias>()
                .Property(e => e.Id_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Licencias>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Licencias>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Nominas>()
                .Property(e => e.Id_nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Nominas>()
                .Property(e => e.Año)
                .IsUnicode(false);

            modelBuilder.Entity<Nominas>()
                .Property(e => e.Mes)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Id_permiso)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Id_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SalidaEmpleado>()
                .Property(e => e.Id_salidaEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<SalidaEmpleado>()
                .Property(e => e.Id_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<SalidaEmpleado>()
                .Property(e => e.TipoSalida)
                .IsUnicode(false);

            modelBuilder.Entity<SalidaEmpleado>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Id_vacaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Id_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Correspondiente)
                .IsUnicode(false);

            modelBuilder.Entity<Vacaciones>()
                .Property(e => e.Comentario)
                .IsUnicode(false);
        }
    }
}
