using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== CALCULADORA DE PROPINAS ===");
            Console.ResetColor();

            Console.Write("Total de la cuenta: ");
            bool okTotal = decimal.TryParse(Console.ReadLine(), out decimal total);

            Console.Write("Porcentaje de propina: ");
            bool okPct = decimal.TryParse(Console.ReadLine(), out decimal porcentaje);

            Console.Write("Número de personas: ");
            bool okPersonas = int.TryParse(Console.ReadLine(), out int personas);

            // Comprobar que los tres datos sean números válidos
            if (okTotal && okPct && okPersonas)
            {
                // Comprobar que los valores tengan sentido
                if (total < 0 || porcentaje < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingresa valores positivos.");
                    Console.ResetColor();
                }
                else if (personas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número de personas debe ser mayor que cero.");
                    Console.ResetColor();
                }
                else
                {
                    decimal propina = total * (porcentaje / 100m);
                    decimal totalFinal = total + propina;
                    decimal porPersona = totalFinal / personas;

                    CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--- RESULTADOS ---");
                    Console.WriteLine($"Propina: {propina.ToString("C0", cultura)}");
                    Console.WriteLine($"Total: {totalFinal.ToString("C0", cultura)}");
                    Console.WriteLine($"Cada persona paga: {porPersona.ToString("C0", cultura)}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato no válido. Por favor, revisa lo que escribiste.");
                Console.ResetColor();
            }

        }
    }
}
