using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasReverso
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = Console.ReadLine();

            char[] array = cadena.ToArray();

            Array.Reverse(array);
            Console.WriteLine(array);
            Console.WriteLine(cadena.Count(e => e == 'e'));

            Console.ReadLine();
        }
    }
}
