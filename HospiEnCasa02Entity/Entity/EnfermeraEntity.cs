using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class EnfermeraEntity
    {
        public int Id { get; set; }
        public string HorasLaborales { get; set; }
        public string TarjetaProfesional { get; set; }
        public int? IdPersona { get; set; }
    }
}
