using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
   public class SignosVitaleLogin
    {

        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();

        public List<SignosVitaleEntity> SignosVitales() {

            List<SignosVitaleEntity> signosVitaleEntities = new List<SignosVitaleEntity>();
            var signosVitalesBaseDatos = hospiCasa01Context.SignosVitales;

            foreach (var signosVitalesBD in signosVitalesBaseDatos)
            {

                SignosVitaleEntity signosVitalesEntity = new SignosVitaleEntity();

                signosVitalesEntity.FechaHora = signosVitalesBD.FechaHora;
                signosVitalesEntity.FrecuenciaCardiaca = signosVitalesBD.FrecuenciaCardiaca;
                signosVitalesEntity.FrecuenciaRespiratoria = signosVitalesBD.FrecuenciaRespiratoria;
                signosVitalesEntity.Glicemias = signosVitalesBD.Glicemias;
                signosVitalesEntity.Id = signosVitalesBD.Id;
                signosVitalesEntity.IdPaciente = signosVitalesBD.IdPaciente;
                signosVitalesEntity.PresionArterial = signosVitalesBD.PresionArterial;
                signosVitalesEntity.Temperatura = signosVitalesBD.Temperatura;
                signosVitalesEntity.Oximetria = signosVitalesBD.Oximetria;

                signosVitaleEntities.Add(signosVitalesEntity);
            }
                return signosVitaleEntities;
            }
        
        }
    }

