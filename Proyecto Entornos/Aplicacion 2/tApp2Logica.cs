using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Entornos.Multiplos3
{
    /// <summary>
    /// Clase de la logica de negocio de la Aplicacion 2
    /// </summary>
    public class tApp2Logica
    {
        /// <summary>
        /// En este metodo se calcula los multiplos de 3 del 1 al valor introducido
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <returns>Devuelve un texto con todos los multiplos</returns>
        public string CalcularMultiplos(int Valor)
        {
            int Numeros = 0;
            string Texto = "Los múltiplos de 3 son: ";

                for (Numeros = 1; Numeros <= Valor; Numeros++)
                {

                    if (Numeros % 3 == 0)
                    {
                        Texto = Texto + Numeros + ", ";
                    }

                }          

            return Texto;
        }
    }
}
