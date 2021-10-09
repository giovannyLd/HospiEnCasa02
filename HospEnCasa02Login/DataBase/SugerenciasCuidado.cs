using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class SugerenciasCuidado
    {
        public int IdSignosVitales { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }

        public virtual SignosVitale SignosVitale { get; set; }
    }
}
