using System;

class programMayor
{
    static void Main()
    {
        
        Console.Write("Ingrese el primer valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        
        if (valor1 == valor2)
        {
            Console.WriteLine("Los valores ingresados deben ser distintos.");
        }
        else
        {
           
            double mayor = (valor1 > valor2) ? valor1 : valor2;

            
            Console.WriteLine("El mayor valor es: " + mayor);
        }
    }
}
