using System.Runtime.Intrinsics.X86;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * **Realizar uma operação com base em dois valores inteiros A e B.* *
                -Exemplo de entrada: A = 3, B = 3
                - Exemplo de saída: A + B = 6.
            */

            Console.WriteLine("A = ");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            int valorB = int.Parse(Console.ReadLine());

            int soma = valorA + valorB;

            Console.WriteLine($"A + B = {soma}");

        }
    }
}
