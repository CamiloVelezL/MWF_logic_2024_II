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
        public string Name { get; set; }
        public int Creditos { get; set; }
        public int Estrato { get; set; }

        public Estudiante (string name, int creditos, int estrato)
        {
            Name = name;
            Creditos = creditos;
            Estrato = estrato;
        }
        public override string ToString()
        {
            return ($"Estudiante : Name = {Name}, Creditos = {Creditos}, Estrato = {Estrato} ");

        }

    }
}
