using System;

class Program
{
    static void Main()
    {
        // Paso 1: Solicitar temperatura en Celsius
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Convertir a Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Paso 3: Mostrar el resultado
        Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit.ToString("F2"));
    }
}