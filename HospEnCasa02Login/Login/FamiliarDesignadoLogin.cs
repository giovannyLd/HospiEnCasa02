using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
    public class FamiliarDesignadoLogin
    {

        hospiCasa01Context hospiCasa01Context = new hospiCasa01Context();
        public List<FamiliarDesignadoEntity> familiarDesignado()
        {

            List<FamiliarDesignadoEntity> familiarDesignadoEntities = new List<FamiliarDesignadoEntity>();
            var familiarDesignadoBaseDatos = hospiCasa01Context.FamiliarDesignados;

            foreach (var familiarDesignadoBD in familiarDesignadoBaseDatos)
            {

                FamiliarDesignadoEntity familiarDesignadoEntity = new FamiliarDesignadoEntity();

                familiarDesignadoEntity.Id = familiarDesignadoBD.Id;
                familiarDesignadoEntity.IdPersona = familiarDesignadoBD.IdPersona;
                familiarDesignadoEntity.Parentesco = familiarDesignadoBD.Parentesco;

                familiarDesignadoEntities.Add(familiarDesignadoEntity);
            }

            return familiarDesignadoEntities;
        }
        public FamiliarDesignadoEntity addfamiliarDesignado(FamiliarDesignadoEntity familiarDesignadoEntity)
        {
            hospiCasa01Context.FamiliarDesignados.Add(convertirFamiliarDesignadoEntityABaseDatos(familiarDesignadoEntity));
            hospiCasa01Context.SaveChanges();

            return familiarDesignadoEntity;
        }
        public FamiliarDesignado convertirFamiliarDesignadoEntityABaseDatos(FamiliarDesignadoEntity familiarDesignadoEntity)
        {

            FamiliarDesignado familiarDesignado = new FamiliarDesignado();

            familiarDesignado.Id = familiarDesignadoEntity.Id;
            familiarDesignado.IdPersona = familiarDesignadoEntity.IdPersona;
            familiarDesignado.Parentesco = familiarDesignadoEntity.Parentesco;

            return familiarDesignado;
        }
    }

}
