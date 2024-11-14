//42.Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2023.
//Mostrar por pantalla cada mes con su respectiva venta en pesos y la suma total de ventas de dicho año.


public class Program
{
    private static void Main(string[] args)
    {   //Declaramos los arrays
        string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
            "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        decimal[] sales = new decimal[12];

        decimal suma = 0;

        //vamos a implementar metodos para trabajar un poco de POO:
        //Metodo almacenar ventas
        StoreSales(months,sales);
        //Metodo calcular ventas totales del año 
        CalculateSalesPerYear();
        //Metodo para mostrar ventas
        ShowSales();
    }
    private static void StoreSales(string[] months , decimal[] Sales)
    {
        for (decimal i = 0; i < Sales.Length; i++)
        {
            Console.WriteLine($"Ingrese las ventas del mes {months[(int)i]}");
            Sales[(int)i] =Convert.ToDecimal(Console.ReadLine());
        }

    }
    private static void CalculateSalesPerYear()
    {

    }
    private static void ShowSales()
    {

    }
}