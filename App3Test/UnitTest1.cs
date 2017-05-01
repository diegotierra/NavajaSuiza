using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Entornos.Notas;

namespace App3Test
{
    [TestClass]
    public class UnitTest1
    {
        // Prueba numero 1
        [TestMethod]
        public void Nota0()
        {
            // Preparación del caso de prueba
            int Valor = 0;
            string Esperado = "Muy Deficiente";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 2
        [TestMethod]
        public void NotaInsuficiente()
        {
            // Preparación del caso de prueba
            int Valor = 4;
            string Esperado = "Insuficiente";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 3
        [TestMethod]
        public void NotaSuficiente()
        {
            // Preparación del caso de prueba
            double Valor = 5.5;
            string Esperado = "Suficiente";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 4
        [TestMethod]
        public void NotaBien()
        {
            // Preparación del caso de prueba
            double Valor = 6.7;
            string Esperado = "Bien";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 5
        [TestMethod]
        public void NotaNotable()
        {
            // Preparación del caso de prueba
            int Valor = 8;
            string Esperado = "Notable";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

        // Prueba numero 6
        [TestMethod]
        public void NotaSobresaliente()
        {
            // Preparación del caso de prueba
            int Valor = 10;
            string Esperado = "Sobresaliente";
            string Salida;

            // Acción a probar
            Salida = tApp3Logica.CalificarNota(Valor);

            //Comprobacion del resultado
            string.Equals(Esperado, Salida);
        }

    }
}
