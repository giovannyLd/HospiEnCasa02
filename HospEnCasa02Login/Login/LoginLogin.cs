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

        public bool logueo(LoginEntity loginEntity)
        {


            var validacion = false;
           // List<LoginEntity> ListaPersona = new List<LoginEntity>();
          //  LoginEntity loginEntities = new LoginEntity();

            var loginBaseDatos = hospiBD.Personas;
      
           foreach (var LoginBD in loginBaseDatos) {

                if (loginEntity.Id == LoginBD.Id) {

                    validacion = true;

                    return validacion;

                  //  ListaPersona.Add(loginEntities);
                       
                }
            }
            return validacion;

        }


    }
}
