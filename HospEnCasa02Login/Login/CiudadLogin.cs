using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
   public class CiudadLogin
    {
        hospiCasa01Context hospiCasa01Constext = new hospiCasa01Context();

        public List<CiudadEntity> ciudad() {

            List<CiudadEntity> ciudadEntities = new List<CiudadEntity>();
            var ciudadBaseDatos = hospiCasa01Constext.Ciudads;

            foreach (var ciudadBD in ciudadBaseDatos) {

                CiudadEntity ciudadEntity = new CiudadEntity();

                ciudadEntity.Id = ciudadBD.Id;
                ciudadEntity.NombreCiudad = ciudadBD.NombreCiudad;

                ciudadEntities.Add(ciudadEntity);
            }

            return ciudadEntities;
        
        
        }

        public CiudadEntity addCiudad(CiudadEntity ciudadEntity) {

            hospiCasa01Constext.Ciudads.Add(convertirCiudadEntityACiudadBD(ciudadEntity));
            hospiCasa01Constext.SaveChanges();

            return ciudadEntity;

        }

        public Ciudad convertirCiudadEntityACiudadBD(CiudadEntity ciudadEntity) {

            Ciudad ciudad = new Ciudad();

            ciudad.Id = ciudadEntity.Id;
            ciudad.NombreCiudad = ciudadEntity.NombreCiudad;

            return ciudad;
        
        }

    }
}
