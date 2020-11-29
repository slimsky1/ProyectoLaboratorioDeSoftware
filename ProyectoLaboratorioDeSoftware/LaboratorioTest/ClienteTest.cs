using System;
using System.Text.RegularExpressions;
using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaboratorioTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void Cliente_NombreValido_Validate()
        {

            Cliente client = new Cliente();
            client.Nombre = "Marcelo";
            Boolean esperado = true;

            Boolean respuesta = client.Validate();

            Assert.AreEqual(esperado, respuesta);
        }

        [TestMethod]
        public void Cliente_NombreInvalido_Validate()
        {

            Cliente client = new Cliente();
            client.Nombre = "Marcelo123";
            Boolean esperado = false;

            Boolean respuesta = client.Validate();

            Assert.AreEqual(esperado, respuesta);
        }
    }
}
