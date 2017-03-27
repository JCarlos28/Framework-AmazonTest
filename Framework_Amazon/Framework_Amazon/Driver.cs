using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework_Amazon
{
    public  class Driver
    {
        public static IWebDriver Instance { get; set; }
       
        public static void initialize()
        {

            Instance = new ChromeDriver();
            
        }

        
    }
}
