using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0; int num2 = 0;

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Consola De Calculadora C#\r");
            Console.WriteLine("------------------------\n");

            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Escriba un número y luego presione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escriba un número y luego presione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Tu opcion? ");

            
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}