namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Verificar se a soma de A + B é menor que C.

                Exemplo de entrada: A = 5, B = 3, C = 10
                Exemplo de saída: A + B é menor que C.

             */

            Console.Write("A = ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("B = ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.Write("C = ");
            int c = Convert.ToInt16(Console.ReadLine());

            string resultado = a + b < c ? "A + B é menor que C" : "A + B é maior que C";

            Console.WriteLine(resultado);

        }
    }
}
