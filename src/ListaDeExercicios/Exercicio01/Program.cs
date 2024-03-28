namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/


            Console.WriteLine("Vamos calcular o volume de caixa retangular");
            Console.WriteLine("Informe o Altura: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Largura: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o Comprimento: ");
            double v3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Caixa possui um volume de " + (v1 * v2 * v3).ToString("F2"));

        }
    }
}
