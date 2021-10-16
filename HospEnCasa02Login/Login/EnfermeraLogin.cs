using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public  class EnfermeraLogin
    {

        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();
        public List<EnfermeraEntity> enfermera() 
        {
            List<EnfermeraEntity> listEnfermeraEntities = new List<EnfermeraEntity>();

            var enfermeraBaseDatos = hospiCasa01Context.Enfermeras;

            foreach (var enfermeraBD in enfermeraBaseDatos) 
            {

                EnfermeraEntity enfermeraEntity = new EnfermeraEntity();

                enfermeraEntity.Id = enfermeraBD.Id;
                enfermeraEntity.IdPersona = enfermeraBD.IdPersona;
                enfermeraEntity.HorasLaborales = enfermeraBD.HorasLaborales;
                enfermeraEntity.TarjetaProfesional = enfermeraBD.TarjetaProfesional;

                listEnfermeraEntities.Add(enfermeraEntity);
            }

            return listEnfermeraEntities;


        }
        public EnfermeraEntity addEnfermera(EnfermeraEntity enfermera)
        {
            hospiCasa01Context.Enfermeras.Add(convertirEnfermeraEntityAEnfermeraBaseDatos(enfermera));
            hospiCasa01Context.SaveChanges();

            return enfermera;
        }


        public Enfermera convertirEnfermeraEntityAEnfermeraBaseDatos(EnfermeraEntity enfermeraEntity)
        {

            Enfermera enfermera = new Enfermera(); //se crea el objeto

            enfermera.HorasLaborales = enfermeraEntity.HorasLaborales;
            enfermera.Id = enfermeraEntity.Id;
            enfermera.TarjetaProfesional = enfermeraEntity.TarjetaProfesional;
            enfermera.IdPersona = enfermeraEntity.IdPersona;

            return enfermera;

        }
    }
}
