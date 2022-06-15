using System;

namespace ConsoleAppEjercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Conversión de Medidas");
                Console.WriteLine("(C)entímetros");
                Console.WriteLine("(P)ulgadas");
                Console.Write("Ingrese una opción C o P:");
                var opcion = Console.ReadLine();
                if (opcion.ToUpper() == "C" || opcion.ToUpper() == "P")
                {
                    if (opcion.ToUpper() == "C")
                    {
                        Console.Write("Ingrese una medida en centímetros:");
                        var centimetros = float.Parse(Console.ReadLine());
                        var pulgadas = centimetros * 0.39370f;
                        Console.WriteLine($"{centimetros} cms equivalen a {pulgadas} pulgadas");
                    }
                    else
                    {
                        Console.Write("Ingrese la medida en pulgadas:");
                        var pulgadas = float.Parse(Console.ReadLine());
                        var centimetros = pulgadas / 0.39370f;
                        Console.WriteLine($"{pulgadas} pulgadas equivalen a {centimetros} cms");
                    }

                }
                else
                {
                    Console.WriteLine("Opción errónea o no contemplada");
                }


            }
            catch (Exception)
            {

                Console.WriteLine("Ingreso de datos erróneo...");
                
            }   
            Console.ReadLine();
        }
    }
}
