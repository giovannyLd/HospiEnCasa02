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
        hospiCasa01Context hospiBaseDatos = new hospiCasa01Context();
        public LoginEntity logueo(LoginEntity loginEntity) {



          var hola =   loginEntity.Id;


            return loginEntity;

        }

    }
}
