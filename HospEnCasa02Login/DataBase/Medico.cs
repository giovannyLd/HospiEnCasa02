using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class Medico
    {
        public Medico()
        {
            Pacientes = new HashSet<Paciente>();
        }
        //medico
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public string TarjetaProfesional { get; set; }
        public int? IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
