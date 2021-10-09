using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class Paciente
    {
        public int Id { get; set; }
        public int? IdCasaPaciente { get; set; }
        public int? IdFamiliarDesignado { get; set; }
        public int? IdEnfermera { get; set; }
        public int? IdMedico { get; set; }
        public int? IdSignosVitales { get; set; }
        public int? IdPersona { get; set; }

        public virtual CasaPaciente IdCasaPacienteNavigation { get; set; }
        public virtual Enfermera IdEnfermeraNavigation { get; set; }
        public virtual FamiliarDesignado IdFamiliarDesignadoNavigation { get; set; }
        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual SignosVitale IdSignosVitalesNavigation { get; set; }
    }
}
