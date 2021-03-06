using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class MedicoLogin
    {

        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();
        public List<MedicoEntity> medico()
        {

            List<MedicoEntity> medicoEntities = new List<MedicoEntity>();
            var medicoBaseDatos = hospiCasa01Context.Medicos;

            foreach (var medicoBD in medicoBaseDatos)
            {

                MedicoEntity medicoEntity = new MedicoEntity();

                medicoEntity.Id = medicoBD.Id;
                medicoEntity.IdPersona = medicoBD.IdPersona;
                medicoEntity.TarjetaProfesional = medicoBD.TarjetaProfesional;
                medicoEntity.Especialidad = medicoBD.Especialidad;

                medicoEntities.Add(medicoEntity);
            }

            return medicoEntities;

        }
        public MedicoEntity addMedico(MedicoEntity medico)
        {

            hospiCasa01Context.Medicos.Add(converMedicoEntityABaseDatos(medico));
            hospiCasa01Context.SaveChanges();

            return medico;
        }
        public Medico converMedicoEntityABaseDatos(MedicoEntity medicoEntity)
        {

            Medico medico = new Medico();

            medico.Id = medicoEntity.Id;
            medico.Especialidad = medicoEntity.Especialidad;
            medico.IdPersona = medicoEntity.IdPersona;
            medico.TarjetaProfesional = medicoEntity.TarjetaProfesional;


            return medico;

        }
    }
}

