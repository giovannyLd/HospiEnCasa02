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
    }
}