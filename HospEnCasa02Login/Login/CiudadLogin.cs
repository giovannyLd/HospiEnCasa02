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
        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();

        public List<CiudadEntity> ciudad() {

            List<CiudadEntity> ciudadEntities = new List<CiudadEntity>();
            var ciudadBaseDatos = hospiCasa01Context.Ciudads;

            foreach (var ciudadBD in ciudadBaseDatos) {

                CiudadEntity ciudadEntity = new CiudadEntity();

                ciudadEntity.Id = ciudadBD.Id;
                ciudadEntity.NombreCiudad = ciudadBD.NombreCiudad;
                ciudadEntities.Add(ciudadEntity);
            }

            return ciudadEntities;
        
        
        }

        public CiudadEntity addCiudad(CiudadEntity ciudadEntity) {

            hospiCasa01Context.Ciudads.Add(convertirCiudadEntityACiudadBD(ciudadEntity));
            hospiCasa01Context.SaveChanges();

            return ciudadEntity;

        }

        public Ciudad convertirCiudadEntityACiudadBD(CiudadEntity ciudadEntity) {

            Ciudad ciudad = new Ciudad();

            ciudad.Id = ciudadEntity.Id;
            ciudad.NombreCiudad = ciudadEntity.NombreCiudad;

            return ciudad;
        
        }

        //public List<CiudadEntity>GetAllCiudad(int ciudad)
        //    {


        //    List<CiudadEntity> listCiudadEntity = new List<CiudadEntity>();
        //    var ciudadDataBase = hospiCasa01Context.Ciudads.Where(x => x.Id == ciudad).ToList();

        //    foreach (var CiudadBD in ciudadDataBase)
        //    {
        //        CiudadEntity ciudadEntity = new CiudadEntity();
        //        ciudadEntity.Id = CiudadBD.Id;
        //        ciudadEntity.NombreCiudad = CiudadBD.NombreCiudad;


        //        var familiarDataBase = hospiCasa01Context.CasaPacientes.Where(x => x.IdCiudad == CiudadBD.Id);
        //        ciudadEntity.NombreCiudad = CiudadBD.NombreCiudad;
        //        listCiudadEntity.Add(ciudadEntity);
           
        //    }

        
        }

    }

