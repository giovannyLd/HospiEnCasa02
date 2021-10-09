using HospiEnCasa02Entity.Entity;
using HospEnCasa02Login.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class PersonaLogin
    {
        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();
        public List<PersonaEntity> persona() {

            List<PersonaEntity> personaEntities= new List<PersonaEntity>();
            var personaDataBase = hospiCasa01Context.Personas.ToList();

            foreach (var personaBD in personaDataBase) 
            {
                PersonaEntity personaEntity = new PersonaEntity();

                personaEntity.Id = personaBD.Id;
                personaEntity.Nombre = personaBD.Nombre;
                personaEntity.Apellido = personaBD.Apellido;
                personaEntity.Telefono = personaBD.Telefono;
                personaEntity.Genero = personaBD.Genero;
                personaEntity.FechaNacimiento = personaBD.FechaNacimiento;
                personaEntity.Correo = personaBD.Correo;


                personaEntities.Add(personaEntity);

            }
            return personaEntities;

        } 
    }
}
