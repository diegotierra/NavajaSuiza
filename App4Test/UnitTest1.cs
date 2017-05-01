using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Entornos.SumarPares;

namespace App4Test
{
    [TestClass]
    public class UnitTest1
    {
        // Prueba numero 1
        [TestMethod]
        public void Valor0()
        {
            // Preparación del caso de prueba 
            int Valor = 0;
            int Esperado = 0;
            int Salida;

            // Acción a probar 
            Salida = tApp4Logica.SumarPares(Valor);

            //Comprobacion del resultado
            Assert.AreEqual(Esperado, Salida, 0.001, "No se ha producido la operacion correctamente");
        }

        // Prueba numero 2
        [TestMethod]
        public void ValorNoPar()
        {
            // Preparación del caso de prueba
            int Valor = 1;
            int Esperado = 0;
            int Salida;

            // Acción a probar
            Salida = tApp4Logica.SumarPares(Valor);

            //Comprobacion del resultado
            Assert.AreEqual(Esperado, Salida, 0.001, "No se ha producido la operacion correctamente");
        }

        // Prueba numero 3
        [TestMethod]
        public void ValorPar()
        {
            // Preparación del caso de prueba
            int Valor = 4;
            int Esperado = 6;
            int Salida;

            // Acción a probar
            Salida = tApp4Logica.SumarPares(Valor);

            //Comprobacion del resultado
            Assert.AreEqual(Esperado, Salida, 0.001, "No se ha producido la operacion correctamente");
        }
    }
}
