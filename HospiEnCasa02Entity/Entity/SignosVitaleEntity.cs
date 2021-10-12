using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class SignosVitaleEntity
    {
        public int Id { get; set; }
        public DateTime? FechaHora { get; set; }
        public int? Oximetria { get; set; }
        public double? FrecuenciaRespiratoria { get; set; }
        public double? FrecuenciaCardiaca { get; set; }
        public double? Temperatura { get; set; }
        public int? PresionArterial { get; set; }
        public double? Glicemias { get; set; }
        public int? IdPaciente { get; set; }

    }
}
