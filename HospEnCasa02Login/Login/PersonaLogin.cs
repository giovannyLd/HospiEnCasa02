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

                personaEntities.Add(convertirPersonaBaseDatosToPersonaEntity(personaBD));

            }
            return personaEntities;

        }

        public PersonaEntity addPerson(PersonaEntity personaEntity) {

            hospiCasa01Context.Personas.Add(convertirPersonaEntityToPersonaBaseDatos(personaEntity));
            hospiCasa01Context.SaveChanges();

            return personaEntity;
        }

        public Persona convertirPersonaEntityToPersonaBaseDatos(PersonaEntity personaEntity) {

            Persona persona = new Persona();

            persona.Id = personaEntity.Id;
            persona.Nombre = personaEntity.Nombre;
            persona.Apellido = personaEntity.Apellido;
            persona.Telefono = personaEntity.Telefono;
            persona.Genero = personaEntity.Genero;
            persona.FechaNacimiento = personaEntity.FechaNacimiento;
            persona.Correo = personaEntity.Correo;

            return persona;
        }

        public PersonaEntity convertirPersonaBaseDatosToPersonaEntity(Persona persona)
        {

            PersonaEntity personaEntity = new PersonaEntity();

            personaEntity.Id = persona.Id;
            personaEntity.Nombre = persona.Nombre;
            personaEntity.Apellido = persona.Apellido;
            personaEntity.Telefono = persona.Telefono;
            personaEntity.Genero = persona.Genero;
            personaEntity.FechaNacimiento = persona.FechaNacimiento;
            personaEntity.Correo = persona.Correo;

            return personaEntity;
        }
    }
}
