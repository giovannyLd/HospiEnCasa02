using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            CasaPacientes = new HashSet<CasaPaciente>();
        }

        public int Id { get; set; }
        public string NombreCiudad { get; set; }

        public virtual ICollection<CasaPaciente> CasaPacientes { get; set; }
    }
}
