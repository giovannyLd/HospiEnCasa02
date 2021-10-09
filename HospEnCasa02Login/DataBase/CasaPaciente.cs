using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class CasaPaciente
    {
        public CasaPaciente()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Direccion { get; set; }
        public int? IdCiudad { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
