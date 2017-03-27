using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Amazon
{
    //abrir la pagina y maximizar
    public  class OpenPage
    {
        public static void OpenPageAndMax()
        {
            Driver.Instance.Url = "https://www.amazon.com/";
            Driver.Instance.Manage().Window.Maximize();
        }
    }
}
