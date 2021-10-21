using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospiEnCasa02Entity.Entity
{
    public class PersonaEntity:BaseEntity
    {


        [Required(ErrorMessage = "Identificacion Requerida")]
        [RegularExpression("[0-9]*", ErrorMessage = "La Identificacion debe tener solo numeros")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido Requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Celular Requerido")]
        [Phone]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "La telefono debe tener minimo 7 caracteres y maximo 10")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Genero Requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "FechaNacimiento Requerido")]
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Correo Requerido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Contraseña Requerida")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener minimo 6 caracteres y maximo 100")]
        public string Password { get; set; }
    }
  
    }

