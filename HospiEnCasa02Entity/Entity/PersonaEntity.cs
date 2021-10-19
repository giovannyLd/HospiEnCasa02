using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class PersonaEntity: BaseEntity
    {

 

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }

        [Required(ErrorMessage = "Contraseña Requerida")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener minimo 10 caracteres y maximo 100")]
        public string Password { get; set; }
    }
  
    }

