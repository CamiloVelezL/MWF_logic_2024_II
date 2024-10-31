/*32.Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera:


1· Si toma 20 o menos créditos, paga el crédito al valor normal.
2· Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
3· Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
   - Si el estrato es 1, el descuento es del 80%.
   - Si el estrato es 2, el descuento es del 50%.
   - Si el estrato es 3, el descuento es del 30%.

Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:

1· Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
2· Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.

Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.

La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
Hacer uso de todos los elementos de programación que hemos visto hasta el momento, incluyendo POO (clases, propiedades, métodos)*/

using Calculadora_Estudiante;
using Matricula_Estudiante;
using Validador_Estudiante;

// INSTANCIAR LAS CLASES EN EL MAIN PROGRAMA/USUARIO

Calculadoramatricula calculaddora = new Calculadoramatricula();

while (true)
{
    try
    {
        Console.WriteLine("\n--- Calculadora de Matrícula ---");

        int creditos = Validador.SolicitarEntero("Ingrese el número de créditos: ");
        Validador.ValidarValorCredito(creditos);

        int estrato = Validador.SolicitarEntero("Ingrese el estrato (1-6): ");
        Validador.ValidadorEstrato(estrato);

        decimal valorCredito = Validador.SolicitarNumeroDecimal("Ingrese el valor del crédito: ");
        Validador.ValidarValorCredito(valorCredito);

        Estudiante estudiante = new Estudiante(creditos, estrato);

        decimal costoMatricula = Calculadoramatricula.CalcularMatricula(estudiante, valorCredito);

        decimal subsidio = Calculadoramatricula.CalcularSubsidio(estudiante, estrato);

        MostrarResultados(costoMatricula, subsidio);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    if (!ContinuarPrograma())
    {
        break;
    }
}

Console.WriteLine(" ¡Hasta pronto! ");

void MostrarResultados(decimal costoMatricula, decimal subsidio)
{
    Console.WriteLine($"\nResultados:");
    Console.WriteLine($"Costo de la matrícula: ${costoMatricula:N2}");
    Console.WriteLine($"Valor del subsidio: ${subsidio:N2}");
}

bool ContinuarPrograma()
{
    while (true)
    {
        Console.Write("\n¿Desea calcular la matrícula de otro estudiante? (s/n): ");
        string respuesta = Console.ReadLine().Trim().ToLower();
        if (respuesta == "s" || respuesta == "si")
        {
            return true;
        }
        else if (respuesta == "n" || respuesta == "no")
        {
            return false;
        }
        Console.WriteLine("Responda 's' para sí o 'n' para no.");
    }
}
