using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class Persona
    {
        public Persona()
        {
            Enfermeras = new HashSet<Enfermera>();
            FamiliarDesignados = new HashSet<FamiliarDesignado>();
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Enfermera> Enfermeras { get; set; }
        public virtual ICollection<FamiliarDesignado> FamiliarDesignados { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
