using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Framework_Amazon
{
    public  class  Login
    {
        // la clase para testear el login.
        public static void CanLogin(string correo, string passw)
        {
            Utilidades.Click("nav-link-accountList","Id");
            //Thread.Sleep(5000);
            Utilidades.FillFields("ap_email", "Id",correo);
            Utilidades.FillFields("ap_password", "Id", passw);
            Utilidades.Click("signInSubmit", "Id");
            
        }
    }
}
