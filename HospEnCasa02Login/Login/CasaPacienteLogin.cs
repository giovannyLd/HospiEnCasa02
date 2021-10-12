using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class CasaPacienteLogin
    {
        //prueba giova
        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();
        public List<CasaPacienteEntity> casaPaciente()
        {

            List<CasaPacienteEntity> casaPacienteEntities = new List<CasaPacienteEntity>();
            var casaPacienteBaseDatos = hospiCasa01Context.CasaPacientes;

            foreach (var casaPacienteBD in casaPacienteBaseDatos)
            {
                CasaPacienteEntity casaPacienteEntity = new CasaPacienteEntity();

                casaPacienteEntity.Id = casaPacienteBD.Id;
                casaPacienteEntity.IdCiudad = casaPacienteBD.IdCiudad;
                casaPacienteEntity.Latitud = casaPacienteBD.Latitud;
                casaPacienteEntity.Longitud = casaPacienteBD.Longitud;
                casaPacienteEntity.Direccion = casaPacienteBD.Direccion;


                casaPacienteEntities.Add(casaPacienteEntity);
            }

            return casaPacienteEntities;
        }

        public CasaPacienteEntity addCasaPaciente(CasaPacienteEntity casaPacienteEntity) {

            hospiCasa01Context.CasaPacientes.Add(convercasaPacienteentityToCasaPacienteBD(casaPacienteEntity));
            hospiCasa01Context.SaveChanges();

            return casaPacienteEntity;
        }


        public CasaPaciente convercasaPacienteentityToCasaPacienteBD(CasaPacienteEntity casaPacienteEntity) {

            CasaPaciente casaPaciente = new CasaPaciente();

            casaPaciente.Id = casaPacienteEntity.Id;
            casaPaciente.IdCiudad = casaPacienteEntity.IdCiudad;
            casaPaciente.Latitud = casaPacienteEntity.Latitud;
            casaPaciente.Longitud = casaPacienteEntity.Longitud;
            casaPaciente.Direccion = casaPacienteEntity.Direccion;

            return casaPaciente;
        }
    }
}