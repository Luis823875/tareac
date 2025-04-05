using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        
        double fahrenheit = (celsius * 9 / 5) + 32;

        
        Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit.ToString("F2"));
    }
}
