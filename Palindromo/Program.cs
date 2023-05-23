using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabraNueva = string.Empty;
            Console.WriteLine("Escribe una palabra para verificar si es palindroma");
            string texto = Console.ReadLine();

            int i = texto.Length;

            for (int j = i - 1; j >= 0; j--)
            {
                palabraNueva = palabraNueva + texto[j];
            }
            if (palabraNueva == texto)
            {
                Console.WriteLine("La palabra es palindroma");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La palabra no es palindroma");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
