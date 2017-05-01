using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Entornos.Factorial
{ 
    /// <summary>
    /// Clase de la logica de negocio de la Aplicacion 1
    /// </summary>
   public class tApp1Logica
    {
        /// <summary>
        /// En esta funcion calcula el factorial de un numero que le pasamos por parametros
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="Numero">Es el valor que el usuario introduce</param>
        /// <returns>Devuelve el factorial</returns>
        public int CalcularFactorial(int Numero)
        {
            int Resultado = 1;

                while (Numero > 0)
                {
                    Resultado = Resultado * Numero;
                    Numero--;
                }

            return Resultado;
        }
    }
}
