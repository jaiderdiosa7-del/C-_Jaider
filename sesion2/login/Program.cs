using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su usuario: ");
            string user = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese su Constraseña:");
            string pass = Console.ReadLine().ToLower().Trim();

            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("Bienvenido al Sistema");
                Console.WriteLine("Calculadora con Switch");
                Console.WriteLine("Digite el valor para A");
                string entrada = Console.ReadLine().Trim();
                int a = Convert.ToInt32(entrada);
                Console.WriteLine("Digite el valor para B");
                float b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la opcion deseada: ");
                //Console.WriteLine("1. SUMAR ");
                //Console.WriteLine("2. RESTAR");
                //Console.WriteLine("3. MULTIPLICAR");
                //Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("1.SUMAR \n 2. RESTAR \n 3. MULTIPLICAR \n 4. DIVIDIR");
                int opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"La suma de {a} + {b} es {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de {a} - {b} es {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicacion de {a} * {b} es {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                            Console.WriteLine("No se puede dividir entre Cero (0)");
                        else
                        Console.WriteLine($"La division de {a} / {b} es {a / b}");
                        break;
                    case 5:
                        double nota = Convert.ToDouble(Console.ReadLine());
                        if (nota < 0 || nota > 5)
                            Console.WriteLine("La nota debe ser entre 0.0 y 5.0");
                        else
                        {
                            if (nota <= 3.0)
                                Console.WriteLine("Nota deficiente");
                            else if (nota < 4)
                                Console.WriteLine("Nota aceptable");
                            else if (nota < 4.6)
                                Console.WriteLine("Nota sobresaliente");
                            else
                                Console.WriteLine("Nota excelente");
                        }
                        break;
                    default:
                        Console.WriteLine("Eleccion incorrecta");
                        break;


                }
            }
            else
            {
                Console.WriteLine("Error en el usuario o contraseña");
            }
        }
    }
}
