using System;

namespace CalculoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lê os dados da primeira peça
            string[] peca1 = Console.ReadLine().Split(" ");
            int peca1Cod = int.Parse(peca1[0]);
            int peca1Qtd = int.Parse(peca1[1]);
            double peca1Valor = double.Parse(peca1[2]);

            // Lê os dados da segunda peça
            string[] peca2 = Console.ReadLine().Split(" ");
            int peca2Cod = int.Parse(peca2[0]);
            int peca2Qtd = int.Parse(peca2[1]);
            double peca2Valor = double.Parse(peca2[2]);

            // Calcula o total
            double total = (peca1Qtd * peca1Valor) + (peca2Qtd * peca2Valor);

            Console.WriteLine(peca1Qtd);
            Console.WriteLine(peca1Valor);
            Console.WriteLine(peca2Qtd);
            Console.WriteLine(peca2Valor);
            // Imprime o resultado com 2 casas decimais
            Console.WriteLine("TOTAL A PAGAR = R$ " + total.ToString("F2"));
        }
    }
}
