using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1: Convertir segundos a horas, minutos y segundos.
            Console.WriteLine("===== EJERCICIO 1: SEGUNDOS A RELOJ =====");

            Console.Write("Ingrese la cantidad de segundos: ");
            int segundos = int.Parse(Console.ReadLine() ?? "0");

            // "/" obtiene la división entera y "%" obtiene el residuo.
            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segundosRestantes = segundos % 60;

            // El símbolo $ permite mostrar variables dentro del texto con {}.
            Console.WriteLine($"Resultado: {horas} h {minutos} min {segundosRestantes} s");


            // EJERCICIO 2: Convertir grados Celsius a Fahrenheit.
            Console.WriteLine("\n===== EJERCICIO 2: TEMPERATURA =====");

            Console.Write("Ingrese los grados Celsius: ");
            string entrada = Console.ReadLine() ?? "";

            // TryParse valida si el texto es un número.
            // "out" guarda el número convertido en la variable celsius.
            if (double.TryParse(entrada, out double celsius))
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"Resultado: {fahrenheit:F1} °F");
            }
            else
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }


            // EJERCICIO 3: Calcular el promedio de tres notas.
            Console.WriteLine("\n===== EJERCICIO 3: PROMEDIO DE NOTAS =====");

            Console.Write("Ingrese la primera nota: ");
            double nota1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese la segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese la tercera nota: ");
            double nota3 = double.Parse(Console.ReadLine() ?? "0");

            double promedio = (nota1 + nota2 + nota3) / 3;

            //f1 para mostrar la cantidad de numeros que van despues del .(punto)
            Console.WriteLine($"El promedio es: {promedio:F1}");
        }
    }
}
