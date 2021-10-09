﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class FamiliarDesignado
    {
        public FamiliarDesignado()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public string Parentesco { get; set; }
        public int? IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
