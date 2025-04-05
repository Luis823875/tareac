using System;

class programMayor
{
    static void Main()
    {
        // Paso 1 y 2: Solicitar valores
        Console.Write("Ingrese el primer valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        // Validar si son distintos
        if (valor1 == valor2)
        {
            Console.WriteLine("Los valores ingresados deben ser distintos.");
        }
        else
        {
            // Paso 3: Comparar y determinar el mayor
            double mayor = (valor1 > valor2) ? valor1 : valor2;

            // Paso 4: Mostrar el mayor
            Console.WriteLine("El mayor valor es: " + mayor);
        }
    }
}
