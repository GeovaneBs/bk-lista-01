namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ordenar três valores inteiros e diferentes em ordem decrescente.
             * Exemplo de entrada: 5 10 3
             * Exemplo de saída: Os números em ordem decrescente são 10 5 3.
             */

            Console.Write("Número = ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Número = ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Número = ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int[] colecao = { num1, num2, num3 };

            foreach (var item in colecao.OrderDescending())
            {
                Console.Write(item + " ");
            }
        }
    }
}
