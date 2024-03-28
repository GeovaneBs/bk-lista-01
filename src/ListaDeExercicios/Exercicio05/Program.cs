namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Calcular a média ponderada de duas provas realizadas por um aluno.

                        Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
                        Fórmula: Média ponderada = (Nota da primeira prova* Peso da primeira prova) +(Nota da segunda prova* Peso da segunda prova)
                        Exemplo de saída: A média ponderada do aluno é 7.6.
            */


            Console.WriteLine("Calcular a média ponderada de duas provas realizadas por um aluno.");
            Console.Write("Informe a Nota da primeira prova: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o Peso da primeira prova: ");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a Nota da segunda prova: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o Peso da segunda prova: ");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaP = (nota1 * peso1) + (nota2 * peso2);

            Console.WriteLine("A média ponderada do aluno é " + mediaP.ToString("F1"));

        }
    }
}
