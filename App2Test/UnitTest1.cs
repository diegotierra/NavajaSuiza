using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Entornos.Multiplos3;

namespace App2Test
{
    [TestClass]
    public class UnitTest1
    {
        // Prueba numero 1
        [TestMethod]
        public void ValorNoMultiplo()
        {
            // Preparación del caso de prueba
            int Valor = 2;
            string Esperado = "Los múltiplos de 3 son: ";
            string Salida;

            // Acción a probar
            tApp2Logica Multiplos = new tApp2Logica();

           Salida = Multiplos.CalcularMultiplos(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 2
        [TestMethod]
        public void ValorMUltiplo()
        {
            // Preparación del caso de prueba
            int Valor = 9;
            string Esperado = "Los múltiplos de 3 son: 3, 6, 9,";
            string Salida;

            // Acción a probar
            tApp2Logica Multiplos = new tApp2Logica();

            Salida = Multiplos.CalcularMultiplos(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 3
        [TestMethod]
        public void ValorMUltiplo0()
        {
            // Preparación del caso de prueba
            int Valor = 0;
            string Esperado = "Los múltiplos de 3 son:";
            string Salida;

            // Acción a probar
            tApp2Logica Multiplos = new tApp2Logica();

            Salida = Multiplos.CalcularMultiplos(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }
    }
}
