using System;
using HypernovaGastos.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class HYPERNOVALABSContext : DbContext
    {
        public HYPERNOVALABSContext()
        {
        }

        public HYPERNOVALABSContext(DbContextOptions<HYPERNOVALABSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Concepto> Conceptos { get; set; }
        public virtual DbSet<Cuentum> Cuenta { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<GastoDetalle> GastoDetalles { get; set; }
        public virtual DbSet<Puesto> Puestos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
  
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.HasKey(e => e.IdConcepto);

                entity.ToTable("Concepto");

                entity.Property(e => e.IdConcepto).HasColumnName("Id_Concepto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");
            });

            modelBuilder.Entity<Cuentum>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.Property(e => e.IdCuenta).HasColumnName("Id_Cuenta");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.ToTable("Departamento");

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("Empleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdPuesto).HasColumnName("Id_Puesto");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");

                entity.HasOne(d => d.IdPuestoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleado_Puesto");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.IdGasto);

                entity.ToTable("Gasto");

                entity.Property(e => e.IdGasto).HasColumnName("Id_Gasto");

                entity.Property(e => e.CantidadItem).HasColumnName("Cantidad_Item");

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Desde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Hasta");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdConcepto).HasColumnName("Id_Concepto");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.IdEmpleadoAprueba).HasColumnName("Id_Empleado_Aprueba");
                entity.Property(e => e.IdEmpleadoSuperviso).HasColumnName("Id_Empleado_Superviso");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Monto_Total");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gasto_Concepto");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gasto_Empleado");
            });

            modelBuilder.Entity<GastoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdGastoDetalle);

                entity.ToTable("Gasto_Detalle");

                entity.Property(e => e.IdGastoDetalle).HasColumnName("Id_Gasto_Detalle");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Compra");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdCuenta).HasColumnName("Id_Cuenta");

                entity.Property(e => e.IdGasto).HasColumnName("Id_Gasto");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.GastoDetalles)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gasto_Detalle_Cuenta");

                entity.HasOne(d => d.IdGastoNavigation)
                    .WithMany(p => p.GastoDetalles)
                    .HasForeignKey(d => d.IdGasto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gasto_Detalle_Gasto");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.IdPuesto);

                entity.ToTable("Puesto");

                entity.Property(e => e.IdPuesto).HasColumnName("Id_Puesto");

                entity.Property(e => e.CantidadPuesto).HasColumnName("Cantidad_Puesto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaActualizo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualizo");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Baja");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.IdDepartamento).HasColumnName("Id_Departamento");

                entity.Property(e => e.IdSupervisor).HasColumnName("Id_Supervisor");

                entity.Property(e => e.UsuarioActualizo)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Actualizo");

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Baja");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Usuario_Registro");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Puestos)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Puesto_Departamento");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
