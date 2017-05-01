using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Entornos.Factorial;

namespace App1Test
{
    [TestClass]
    public class UnitTest1
    {
        // Prueba numero 1
        [TestMethod]
        public void ValorIgual0()
        {
            // Preparación del caso de prueba
            int Valor = 0;
            int Esperado = 1;
            int Salida;

            // Acción a probar
            tApp1Logica Factorial = new tApp1Logica();

            Salida = Factorial.CalcularFactorial(Valor);

            //Comprobacion del resultado
            Assert.AreEqual(Esperado, Salida, 0.001, "No se ha producido la operacion correctamente");
        }

        // Prueba numero 2
        [TestMethod]
        public void ValorMayor0()
        {
            // Preparación del caso de prueba
            int Valor = 8;
            int Esperado = 40320;
            int Salida;

            // Acción a probar
            tApp1Logica Factorial = new tApp1Logica();

            Salida = Factorial.CalcularFactorial(Valor);

            //Comprobacion del resultado
            Assert.AreEqual(Esperado, Salida, 0.001, "No se ha producido la operacion correctamente");
        }
    }
}
