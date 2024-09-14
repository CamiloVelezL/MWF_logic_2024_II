using System.Diagnostics.CodeAnalysis;
using System.Numerics;

public class Program
{ //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.
    private static void Main(string[] args)
    {
        //Datos de entrada
        // Declarar las variables, en este caso son 4 
        double x1, x2, y1, y2, d;

        //inicializar los variables pidiendolos por pantalla
        Console.Write("Por favor Ingrese el valor de x1:  ");
        x1=Convert.ToDouble(Console.ReadLine()); // convertir el string(letras que entran por el usuario) a numeros para guardarlo en variable tipo Double(numeros)

        Console.Write("Por favor Ingrese el valor de x2:  "); // ReadLine es para leer .... Write es para que el ususario escriba a la maquina o consola
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor Ingrese el valor de y1:  ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor Ingrese el valor de y2:  ");
        y2 = Convert.ToDouble(Console.ReadLine());

        // clases se representan con color verde aguamarina.... framework es .net.....metodos son de color amarillo....

        //Proceso - calculo de variable "d"
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1); //construir por partes 

        double suma = x + y;

        d = Math.Sqrt(suma); //la clase math tiene muchos metodos entre ellos el Sqrt recibe un parametro dentro de sus (),ese parametro 
        //ese parametro es el numero que yo le mando al metodo para que me saque la raiz cuadrada.
        
        Console.Write($"La distancia entre los pares ordenados ("+ x1 + "," + y1 + ") y ("+ x2 +"," + y2 + ") es:" + d );
        //mostrar resultado en pantalla

    }
}