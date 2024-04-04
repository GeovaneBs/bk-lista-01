using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. **Substituir mltiplos de 3 pela palavra "Fizz" e mltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.**
                - Exemplo de sada: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...
            */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
