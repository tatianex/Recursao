using System;

namespace Recursao
{
    class Program
    {
        public static int Fatorial(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else return (n * Fatorial(n -1));
        }

        public static void Main()
        {
            string input;
            int num, result;
            Console.WriteLine("Este programa calcula o fatorial do número que você informar.");
            Console.WriteLine("Informe um número");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            result = Fatorial(num);
            Console.WriteLine("O fatorial de {0} é: {1}", num, result);
        }
    }
}
