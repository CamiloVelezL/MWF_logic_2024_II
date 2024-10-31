/*Se creo esta clase para realizar el calculo de matriclula, descuentos y subsidios que aplican a cada estudiamte para mantener
el (main) lo mas limpio posible */

using Matricula_Estudiante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Estudiante // la encapsulacion esta dentro de la clase Calculadoramatricula.
{
    public class Calculadoramatricula
    {                 //CONSTANTES
        private const int LimiteCreditos = 20;
        private const decimal CreditosExtras = 2.0m;
                      //METODO MATRICULA
        public static decimal CalcularMatricula (Estudiante estudiante, decimal valorCredito)
        {
            decimal CostoBase;
            if (estudiante.Creditos <= LimiteCreditos)
             {
                CostoBase = estudiante.Creditos * valorCredito;
            }
            else
            {
                CostoBase = (LimiteCreditos * valorCredito) + ((estudiante.Creditos - LimiteCreditos) * valorCredito * CreditosExtras);
            }
            decimal descuento = CalcularDescuento(estudiante.Estrato);
            return CostoBase * (1 - descuento);
            }
                    //METODO DESCUENTO
            public static decimal CalcularDescuento(int Estrato)
            {
            switch (Estrato)
            {
                case 1:
                    return 0.80m;
                case 2:
                    return 0.50m;
                case 3:
                    return 0.30m;
                default:
                    return 0m;

            }
        }
                   //METODO SUBSIDIO
            public static decimal CalcularSubsidio(int Estrato)
            {
            switch (Estrato)
            {
                case 1:
                    return 200000m;
                case 2:
                    return 100000m;
                default:
                    return 0m;
            }
        }

        internal static decimal CalcularSubsidio(Estudiante estudiante, int estrato)
        {
            throw new NotImplementedException();
        }
    }

}
