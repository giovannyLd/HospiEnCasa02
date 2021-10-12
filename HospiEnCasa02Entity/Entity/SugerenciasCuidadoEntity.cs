using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    //prueba 2
    public class SugerenciasCuidadoEntity
    {
        public int IdSignosVitales { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
    }
}
