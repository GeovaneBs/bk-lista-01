namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Calcular o consumo de combustível por quilômetro.

            Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
            Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
            Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.
             */

            Console.Write("Informe o KM inicial: ");
            decimal kmI = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o KM final: ");
            decimal kmF = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o consumo de combustível: ");
            decimal consumo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O consumo de combustível por quilômetro é de " + (consumo / (kmF - kmI)).ToString("F1") + " litros/km.");

        }
    }
}
