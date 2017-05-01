using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Entornos.Notas
{
    /// <summary>
    /// Clase de la logica de negocio de la Aplicacion 3
    /// </summary>
    public static class tApp3Logica
    {
        /// <summary>
        /// En esta funcion se califica la nota que le pasamos por parametros
        /// </summary>
        /// <remarks>Nada que comentar</remarks>
        /// <param name="Nota">Es el valor que el usuario introduce</param>
        /// <returns>Devuelve la calificacion correspondiente a la nota</returns>
        public static string CalificarNota(double Nota)
        {
            string Calificacion = "";

            if (Nota >= 0 && Nota < 3)
                Calificacion = "Muy Deficiente";

            else

            if (Nota >= 3 && Nota < 5)
                Calificacion = "Insuficiente";

            else

            if (Nota >= 5 && Nota < 6)
                Calificacion = "Suficiente";

            else

            if (Nota >= 6 && Nota < 7)
                Calificacion = "Bien";

            else

            if (Nota >= 7 && Nota < 9)
                Calificacion = "Notable";

            else

            if (Nota >= 9 && Nota <= 10)
                Calificacion = "Sobresaliente";

            return Calificacion;
        }
    }
}
