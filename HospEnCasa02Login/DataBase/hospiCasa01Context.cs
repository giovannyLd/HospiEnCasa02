using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class hospiCasa01Context : DbContext
    {
        public hospiCasa01Context()
        {
        }

        public hospiCasa01Context(DbContextOptions<hospiCasa01Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CasaPaciente> CasaPacientes { get; set; }
        public virtual DbSet<Ciudad> Ciudads { get; set; }
        public virtual DbSet<Enfermera> Enfermeras { get; set; }
        public virtual DbSet<FamiliarDesignado> FamiliarDesignados { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<SignosVitale> SignosVitales { get; set; }
        public virtual DbSet<SugerenciasCuidado> SugerenciasCuidados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-F6UQNN1;Database=hospiCasa01;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<CasaPaciente>(entity =>
            {
                entity.ToTable("casaPaciente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Direccion).HasMaxLength(50);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.CasaPacientes)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_casaPaciente_Ciudad");
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.ToTable("Ciudad");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NombreCiudad)
                    .HasMaxLength(50)
                    .HasColumnName("nombreCiudad");
            });

            modelBuilder.Entity<Enfermera>(entity =>
            {
                entity.ToTable("Enfermera");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.HorasLaborales)
                    .HasMaxLength(50)
                    .HasColumnName("horasLaborales");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.TarjetaProfesional)
                    .HasMaxLength(50)
                    .HasColumnName("tarjetaProfesional");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Enfermeras)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Enfermera_Persona");
            });

            modelBuilder.Entity<FamiliarDesignado>(entity =>
            {
                entity.ToTable("familiarDesignado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.Parentesco)
                    .HasMaxLength(50)
                    .HasColumnName("parentesco");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.FamiliarDesignados)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_familiarDesignado_Persona");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.ToTable("Medico");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(50)
                    .HasColumnName("especialidad");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.TarjetaProfesional)
                    .HasMaxLength(50)
                    .HasColumnName("tarjetaProfesional");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Medico_Persona");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.ToTable("paciente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdCasaPaciente).HasColumnName("idCasaPaciente");

                entity.Property(e => e.IdEnfermera).HasColumnName("idEnfermera");

                entity.Property(e => e.IdFamiliarDesignado).HasColumnName("idFamiliarDesignado");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdSignosVitales).HasColumnName("idSignosVitales");

                entity.HasOne(d => d.IdCasaPacienteNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdCasaPaciente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_casaPaciente");

                entity.HasOne(d => d.IdEnfermeraNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdEnfermera)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_Enfermera");

                entity.HasOne(d => d.IdFamiliarDesignadoNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdFamiliarDesignado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_familiarDesignado");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_Medico");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_Persona");

                entity.HasOne(d => d.IdSignosVitalesNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdSignosVitales)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_paciente_signosVitales");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .HasColumnName("genero");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<SignosVitale>(entity =>
            {
                entity.ToTable("signosVitales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora");

                entity.Property(e => e.FrecuenciaCardiaca).HasColumnName("frecuenciaCardiaca");

                entity.Property(e => e.FrecuenciaRespiratoria).HasColumnName("frecuenciaRespiratoria");

                entity.Property(e => e.Glicemias).HasColumnName("glicemias");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.Oximetria).HasColumnName("oximetria");

                entity.Property(e => e.PresionArterial).HasColumnName("presionArterial");

                entity.Property(e => e.Temperatura).HasColumnName("temperatura");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.SignosVitale)
                    .HasForeignKey<SignosVitale>(d => d.Id)
                    .HasConstraintName("FK_signosVitales_sugerenciasCuidado");
            });

            modelBuilder.Entity<SugerenciasCuidado>(entity =>
            {
                entity.HasKey(e => e.IdSignosVitales);

                entity.ToTable("sugerenciasCuidado");

                entity.Property(e => e.IdSignosVitales)
                    .ValueGeneratedNever()
                    .HasColumnName("idSignosVitales");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(50)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
