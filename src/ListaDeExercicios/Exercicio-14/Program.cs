using System.Xml;

namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. * *Imprimir a sequncia de Fibonacci at um nmero informado.**
                 -Exemplo de entrada: Nmero = 50
                 - Exemplo de sada: Sequncia de Fibonacci at 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.*/
            
            Console.WriteLine("Sequência de Fibonacci:");
            Console.WriteLine("Informe um valor com numero inteiro: ");
            int valorMaximo = Convert.ToInt16(Console.ReadLine());

            int numero1 = 0;
            int numero2 = 1;
            int proximoNumero;

            for (int i = 0; i < valorMaximo; i++)
            {
                if (i <= 1)
                    proximoNumero = i;
                else
                {
                    proximoNumero = numero1 + numero2;
                    numero1 = numero2;
                    numero2 = proximoNumero;
                }
                if (numero1 >= valorMaximo || numero2 >= valorMaximo || proximoNumero >= valorMaximo)
                {
                    break;
                }
                Console.Write($"{proximoNumero} ");
            }
        }
    }
}
