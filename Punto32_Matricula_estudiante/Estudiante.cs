/*se creo esta clase para almacenar los datos de los estudiantes basandome en encapsulamiento*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_Estudiante
{
    public class Estudiante
    {
        //atributos del estudiante
        
        public int Creditos { get; set; }
        public int Estrato { get; set; }

        public Estudiante (int creditos, int estrato)
        {
           
            Creditos = creditos;
            Estrato = estrato;
        }
        public override string ToString()
        {
            return ($"Estudiante : Creditos = {Creditos}, Estrato = {Estrato} ");

        }

    }
}
