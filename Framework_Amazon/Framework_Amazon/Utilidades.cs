using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_Amazon
{
    public class Utilidades
    {
        // mis utilidades, aqui creo metodos para simplificar los codigos.
        
        public static IWebElement FindElement(string Element, string ElementType)
        {
            switch (ElementType)
            {
                case "ClassName":
                    return Driver.Instance.FindElement(By.ClassName(Element));

                case "Id":
                    return Driver.Instance.FindElement(By.Id(Element));
                case "Name":
                    return Driver.Instance.FindElement(By.Name(Element));
                case "TagName":
                    return Driver.Instance.FindElement(By.TagName(Element));
                case "LinkText":
                    return Driver.Instance.FindElement(By.LinkText(Element));
                default:
                    return Driver.Instance.FindElement(By.CssSelector(Element));

            }
        }
     

        public static void FindElements(string Element, string ElementType, string ElementToFind, int row)
        {
           
            if (ElementType == "Id")
            {
                var ColResult = Driver.Instance.FindElement(By.Id(Element));
                var SelectResult = ColResult.FindElements(By.TagName(ElementToFind))[row];
                SelectResult.Click();
            }




        }
        public static void DropDowns(string Element, string ElementType, string text)
        {
            if (ElementType == "Id")
            {
               
                new SelectElement(Driver.Instance.FindElement(By.Id(Element))).SelectByText(text);

            }
        }

       

        public static void Click(string Element, string ElementType)
        {
            FindElement(Element, ElementType).Click();

        }
        public static void FillFields(string Element, string ElementType, string text)
        {
            FindElement(Element, ElementType).SendKeys(text);
           
        }
    }
}
