internal class Program
{
    public class Ejercicio10
    {
        private static void Main(string[] args)
        //10. Construir un programa que pida por pantalla 3 números y luego diga cuál
        //es el mayor, el del medio y el menor de los números ingresados.
        {
            //Declaración de los inputs
            double num1, num2, num3;
            double mayor, medio, menor;

            //Pedir datos - input:
            Console.Write("A continuaación Ingrese 3 numeros diferentes \n");


            Console.Write("Ingrese el primer número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número:");
            num3 = Convert.ToDouble(Console.ReadLine());

            //Comparación - validación
            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;
                if (num2 > num3)
                {
                    medio = num2;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num2;
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                mayor = num2;
                if (num1 > num3)
                {
                    medio = num1;
                    menor = num3;
                }
                else
                {
                    medio = num3;
                    menor = num1;
                }
            }
            else
            {
                mayor = num3;
                if (num1 > num2)
                {
                    medio = num1;
                    menor = num2;
                }
                else
                {
                    medio = num2;
                    menor = num1;
                }
            }

            //Mostrar mensaje - output
            Console.WriteLine($"\nEl número mayor es: {mayor}");
            Console.WriteLine($"El número del medio es: {medio}");
            Console.WriteLine($"El número menor es: {menor}");
        }
    }
}