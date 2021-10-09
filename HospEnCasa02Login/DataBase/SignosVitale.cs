using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class SignosVitale
    {
        public SignosVitale()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public DateTime? FechaHora { get; set; }
        public int? Oximetria { get; set; }
        public double? FrecuenciaRespiratoria { get; set; }
        public double? FrecuenciaCardiaca { get; set; }
        public double? Temperatura { get; set; }
        public int? PresionArterial { get; set; }
        public double? Glicemias { get; set; }
        public int? IdPaciente { get; set; }

        public virtual SugerenciasCuidado IdNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
