namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcular o Índice de Massa Corporal(IMC) e determinar a condição de peso de um adulto.

            Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
            Fórmula: IMC = Peso / (Altura ^ 2)
            Exemplo de saída: IMC = 22.86(Peso normal).
*/

            Console.WriteLine("Calcular o Índice de Massa Corporal(IMC) e determinar a condição de peso de um adulto.");
            Console.Write("Informe sua altura: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o sei peso: ");
            decimal peso = Convert.ToDecimal(Console.ReadLine());

            decimal indece = peso / (altura * altura);

            string imc =  indece.ToString("F2");

            if (indece < 18.5m)
                Console.WriteLine($"IMC = {imc} considerado Magro");
            if (indece >= 18.5m && indece <= 24.9m)
                Console.WriteLine($"IMC = {imc} considerado Normal");
            if (indece >= 25 &&  indece <= 29.9m)
               Console.WriteLine($"IMC = {imc} considerado Sobrepeso");
            if (indece >= 30 && indece <= 39.9m)
                Console.WriteLine($"IMC = {imc} considerado Obesidade");
            if (indece >= 40)
                Console.WriteLine($"IMC = {imc} considerado Obesidade Grave");


        }
    }
}
