using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class MedicoEntity
    {
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public string TarjetaProfesional { get; set; }
        public int? IdPersona { get; set; }
    }
}
