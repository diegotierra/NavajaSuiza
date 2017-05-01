using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Entornos.SumarPares
{
    /// <summary>
    /// Clase de la logica de negocio de la aplicacion 4
    /// </summary>
    public static class tApp4Logica
    {
        /// <summary>
        /// En esta funcion suma los pares del 1 al numero introducido por parametros
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="Numero">Es el valor que el usuario introduce</param>
        /// <returns>Devuelve la suma de los pares</returns>
        public static int SumarPares(int Numero)
        {
            int Resultado = 0;
            int i = 0;

                for (i = 1; i <= Numero; i++)
                {
                    if (i % 2 == 0)
                        Resultado = Resultado + i;
                }
              
            

            return Resultado;
        }
    }
}
