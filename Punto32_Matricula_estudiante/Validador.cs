/*se creo esta clase para validar todos los datos de entrada y tener el codigo lo mas legible y facil de entender */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Validador_Estudiante
{
    public class Validador
    {
        public static void ValidadorCreditos(int creditos) 
        {
            if (creditos <= 0)
            {
            throw new Exception (" El total de creditos debe ser mayor a cero. ");
            }
        }
        public static void ValidadorEstrato(int estrato)
        {
            if (estrato < 1 || estrato >= 6)
            {
                throw new Exception("El estrato debe estar en el rango entre 1 y 6. ");
            }
        }
        public static void ValidarValorCredito(decimal valorCredito)
        {
            if (valorCredito < 0) 
            {
                    throw new Exception("El valor del credito debe ser mayor a cero. ");
            }
            
        }
        public static int SolicitarEntero(string mensaje) 
        {
            while (true) 
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out int resultado))
                {
                    return resultado;
                }
                Console.WriteLine("Ingreso un numero valido. ");
            }
            
        }
        public static decimal SolicitarNumeroDecimal(string mensaje)
        {
            while (true)
            { 
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out int resultado)) 
                {
                    return resultado;
                }
                Console.WriteLine("Ingrese un numero Valido. ");
            }
        }
    }

}
