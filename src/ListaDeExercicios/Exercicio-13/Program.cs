namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. * *Calcular o fatorial de um nmero e exibir o resultado.* *
                -Exemplo de entrada: Nmero = 5
                - Exemplo de sada: 5! = 120.
            */

            Console.WriteLine("Informe um número para fatorial");
            int numero = Convert.ToInt16(Console.ReadLine());

            int fatorial = 1;


            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"Fatorial de {numero} é: " + fatorial.ToString());


        }
    }
}
