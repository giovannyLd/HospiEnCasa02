using HospEnCasa02Login.DataBase;
using HospiEnCasa02Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospEnCasa02Login.Login
{
   public  class LoginLogin
    {
        hospiCasa01Context hospiBD = new hospiCasa01Context();

        public List<LoginEntity>  logueo(LoginEntity loginEntity)
        {

            List<LoginEntity> ListaPersona = new List<LoginEntity>();
            LoginEntity loginEntities = new LoginEntity();

            var loginBaseDatos = hospiBD.Personas;
      
           foreach (var LoginBD in loginBaseDatos) {

                if (loginEntity.Id == LoginBD.Id) {

                

                    ListaPersona.Add(loginEntities);
                       
                }
            }
            return ListaPersona;

        }


    }
}
