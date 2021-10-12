using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class SugerenciasCuidadoLogin
    {

        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();

        public List<SugerenciasCuidadoEntity> sugerenciasCuidado() {

            List<SugerenciasCuidadoEntity> sugerenciasCuidadoEntities = new List<SugerenciasCuidadoEntity>();
            var sugerenciaCuidadoBaseDatos = hospiCasa01Context.SugerenciasCuidados;

            foreach (var sugerenciaCuidadoBD in sugerenciaCuidadoBaseDatos) {

                SugerenciasCuidadoEntity sugerenciaCuidadoEntity = new SugerenciasCuidadoEntity();

                sugerenciaCuidadoEntity.Descripcion = sugerenciaCuidadoBD.Descripcion;
                sugerenciaCuidadoEntity.Diagnostico = sugerenciaCuidadoBD.Diagnostico;
                sugerenciaCuidadoEntity.FechaHora = sugerenciaCuidadoBD.FechaHora;
                sugerenciaCuidadoEntity.IdSignosVitales = sugerenciaCuidadoBD.IdSignosVitales;

                sugerenciasCuidadoEntities.Add(sugerenciaCuidadoEntity);
            }

            return sugerenciasCuidadoEntities;
        }
    }
}
