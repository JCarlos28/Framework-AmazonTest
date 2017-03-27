using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Framework_Amazon
{
    // la clase para testear el search and select
    public class SearchAndSelect
    {
        public static void SearchAndSelectItem(string Item)
        {
            Utilidades.FillFields("twotabsearchtextbox", "Id", Item);
            Thread.Sleep(3000);
            Utilidades.Click("nav-input", "ClassName");
            Utilidades.FindElements("resultsCol", "Id", "li", 3);
            Thread.Sleep(3000);
            Utilidades.DropDowns("native_dropdown_selected_size_name", "Id", "Medium");
            Utilidades.DropDowns("native_dropdown_selected_color_name", "Id", "Lime");
            Thread.Sleep(3000);
            Utilidades.Click("add-to-cart-button", "Id");

        }
    }
}
