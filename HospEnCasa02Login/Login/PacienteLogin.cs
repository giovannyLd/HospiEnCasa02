using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class PacienteLogin
    {
        hospiCasa01Context pacienteDBContext = new hospiCasa01Context();
        public List<PacienteEntity> paciente()
        {
            List<PacienteEntity> ListpacienteEntities = new List<PacienteEntity>();
            var pacienteDataBase = pacienteDBContext.Pacientes;

            foreach (var pacienteDB in pacienteDataBase)
            {

                PacienteEntity pacienteEntity = new PacienteEntity();
                pacienteEntity.Id = pacienteDB.Id;
                pacienteEntity.IdCasaPaciente = pacienteDB.IdCasaPaciente;
                pacienteEntity.IdFamiliarDesignado = pacienteDB.IdFamiliarDesignado;
                pacienteEntity.IdEnfermera = pacienteDB.IdEnfermera;
                pacienteEntity.IdMedico = pacienteDB.IdMedico;
                pacienteEntity.IdSignosVitales = pacienteDB.IdSignosVitales;
                pacienteEntity.IdPersona = pacienteDB.IdEnfermera;

                ListpacienteEntities.Add(pacienteEntity);

            }
            return ListpacienteEntities;
        }

        public PacienteEntity addPaciente(PacienteEntity pacienteEntity) {

            pacienteDBContext.Pacientes.Add(converPacienteEntityToPacienteBD(pacienteEntity));
            pacienteDBContext.SaveChanges();

            return pacienteEntity;
        }


        public Paciente converPacienteEntityToPacienteBD(PacienteEntity pacienteEntity) {

            Paciente paciente = new Paciente();

            paciente.Id = pacienteEntity.Id;
            paciente.IdCasaPaciente = pacienteEntity.IdCasaPaciente;
            paciente.IdEnfermera = pacienteEntity.IdEnfermera;
            paciente.IdMedico = pacienteEntity.IdMedico;
            paciente.IdFamiliarDesignado = pacienteEntity.IdFamiliarDesignado;
            paciente.IdSignosVitales = pacienteEntity.IdSignosVitales;
            paciente.IdPersona = pacienteEntity.IdPersona;

            return paciente;
        }
    }
}
