namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Calcular a área de um terreno retangular.

            Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
            Fórmula: Área = Comprimento * Largura
            Exemplo de saída: A área do terreno é 50 metros quadrados.         
             */

            Console.WriteLine("Vamos calcular a área de um terreno retangular");
            Console.Write("Informe o comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("A área do terreno é " + (comprimento * largura).ToString("F2") + " metros quadrados");
        }
    }
}
