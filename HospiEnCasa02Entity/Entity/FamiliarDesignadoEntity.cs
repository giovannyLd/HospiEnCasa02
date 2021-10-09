using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class FamiliarDesignadoEntity
    {

        public int Id { get; set; }
        public string Parentesco { get; set; }
        public int? IdPersona { get; set; }
    }
}
