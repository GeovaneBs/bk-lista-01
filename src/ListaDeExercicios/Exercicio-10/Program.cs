namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Identificar se um número é par ou ímpar.
             * Exemplo de entrada: Número = 7
             * Exemplo de saída: O número é ímpar.
             */
            Console.Write("Informe um numero inteiro: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero % 2 != 0)
                Console.WriteLine($"{numero} é impar");
            else
                Console.WriteLine($"{numero} é par");

        }
    }
}
