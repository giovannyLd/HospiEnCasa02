using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pruebaaaaaaaaaaaaaaa//
namespace HospiEnCasa02Entity.Entity
{
   public class PacienteEntity { 

     public int Id { get; set; }
    public int? IdCasaPaciente { get; set; }
    public int? IdFamiliarDesignado { get; set; }
    public int? IdEnfermera { get; set; }
    public int? IdMedico { get; set; }
    public int? IdSignosVitales { get; set; }
    public int? IdPersona { get; set; }
    
    }
}
