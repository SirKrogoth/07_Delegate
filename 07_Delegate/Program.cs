using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Delegate
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            //Delegate é um ponteiro de métodos

            Calcula calc1 = new Calcula(Somar);
            int soma = calc1(10, 20);

            Calcula calc2 = new Calcula(Subtrair);
            int subtrair = calc2(100, 30);

            /*
            *var soma = Somar(5, 10);
            *var subtrair = Subtrair(5, 10);
            */

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtrair: " + subtrair);

            Console.ReadKey();
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
