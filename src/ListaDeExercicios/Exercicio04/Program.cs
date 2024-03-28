namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Calcular o salário total de um vendedor.

              Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão(5 % sobre as vendas)
              Fórmula: Salário total = Salário base + (Total de vendas *Comissão)
              Exemplo de saída: O salário total do vendedor é R$ 2750.*/


            Console.WriteLine("Calcular o salário total de um vendedor");
            Console.Write("Informe o Salario Base: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o Total de vendas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            double comissao = 0.05;

            Console.WriteLine("O salário total do vendedor é R$ " + (salario + (totalVendas * comissao)).ToString("F2"));

        }
    }
}
