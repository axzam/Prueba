using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using System.Collections.Generic;
using Entidades;
using Lago_Musical;



namespace PruebasUnitariasLogica
{
    [TestClass]
    public class LogicaTest
    {
        [TestMethod]
        public void PruebaParaObtenerListaDeAnimales()
        {

            //Arrange
            int ResultadoEsperado = 3;

            L_Animal Animales = new L_Animal();

            //Act
            var result = Animales.Obtener_Lista_De_Animales();

            //Assert
            Assert.AreEqual(result.Count, ResultadoEsperado);


        }

        
    }
}
