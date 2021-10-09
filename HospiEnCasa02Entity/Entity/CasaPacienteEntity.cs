using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class CasaPacienteEntity
    {
        public int Id { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Direccion { get; set; }
        public int? IdCiudad { get; set; }
    }
}
