using System;
using System.Text.RegularExpressions;
using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaboratorioTest
{
    [TestClass]
    public class DireccionTest
    {
        [TestMethod]
        public void Direccion_DireccionValida_Validate()
        {

            Direccion address = new Direccion();
            address.Calle = "Santa Fe";
            Boolean esperado = true;

            Boolean respuesta = address.Validate();

            Assert.AreEqual(esperado, respuesta);
        }

        [TestMethod]
        public void Direccion_DireccionInvalida_Validate()
        {

            Direccion address = new Direccion();
            address.Calle = "Calle 123";
            Boolean esperado = false;

            Boolean respuesta = address.Validate();

            Assert.AreEqual(esperado, respuesta);
        }
    }
}
