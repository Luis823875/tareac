using System;

class Aumento
{
    static void Main()
    {
        
        Console.Write("Ingrese el sueldo del primer empleado: ");
        double sueldo1 = Convert.ToDouble(Console.ReadLine());
        double nuevoSueldo1 = sueldo1 + (sueldo1 * 0.10);

        
        Console.Write("Ingrese el sueldo del segundo empleado: ");
        double sueldo2 = Convert.ToDouble(Console.ReadLine());
        double nuevoSueldo2 = sueldo2 + (sueldo2 * 0.12);

        
        Console.Write("Ingrese el sueldo del tercer empleado: ");
        double sueldo3 = Convert.ToDouble(Console.ReadLine());
        double nuevoSueldo3 = sueldo3 + (sueldo3 * 0.15);

        
        Console.WriteLine("\n--- Nuevos Sueldos con Aumento ---");
        Console.WriteLine("Primer empleado: $" + nuevoSueldo1.ToString("F2"));
        Console.WriteLine("Segundo empleado: $" + nuevoSueldo2.ToString("F2"));
        Console.WriteLine("Tercer empleado: $" + nuevoSueldo3.ToString("F2"));
    }
}
