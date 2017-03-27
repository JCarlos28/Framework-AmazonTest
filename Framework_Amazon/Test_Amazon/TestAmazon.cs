using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework_Amazon;
//agrego el framework para poder usar sus metodos.
namespace Test_Amazon
{
    [TestClass]
    public class TestAmazon
    {
        [TestInitialize]
        public void init()
        {
            Driver.initialize();
            OpenPage.OpenPageAndMax();   

        }
        // metodo para testear el login de amazon
        [TestMethod]
        public void Login_Test ()
        {
            Login.CanLogin(InputVariables.correo,InputVariables.passW);
           
        }
        // metodo para testear la seleccion de itenes, escribe un item, lo selecciona y luego elige su tama;o y color.
        [TestMethod]
        public void Search_and_Select_Item()
        {
            Login.CanLogin(InputVariables.correo, InputVariables.passW);
            SearchAndSelect.SearchAndSelectItem(InputVariables.shirtName);

        }

    }
}
