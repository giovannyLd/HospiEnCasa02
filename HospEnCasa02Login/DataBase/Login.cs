using System;
using System.Collections.Generic;

#nullable disable

namespace HospEnCasa02Login.DataBase
{
    public partial class Login
    {
        public int? Id { get; set; }
        public string Password { get; set; }

        public virtual Persona IdNavigation { get; set; }
    }
}
