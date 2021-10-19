using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class SugerenciasCuidado
    {
        public SugerenciasCuidado()
        {
            SignosVitales = new HashSet<SignosVitale>();
        }

        public int IdSignosVitales { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }

        public virtual ICollection<SignosVitale> SignosVitales { get; set; }
    }
}
