namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius.

                Exemplo de entrada: Temperatura em Fahrenheit = 68
                Fórmula: Celsius = (Fahrenheit - 32) * 5/9
                Exemplo de saída: A temperatura em Celsius é 20 °C.

             */

            Console.WriteLine("Conversão de Fahrenheit para graus Celsius");

            Console.WriteLine("Informe a Temperatura Fahrenheit");
            double tempF = Convert.ToDouble(Console.ReadLine());

            double tempC = (tempF - 32) * 5 / 9;

            Console.WriteLine("A temperatura em Celsius é " + tempC.ToString("F1") + " °C");

        }
    }
}
