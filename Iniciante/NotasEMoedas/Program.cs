namespace NotasEMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorTotal = double.Parse(Console.ReadLine());

            // Notas
            int notas100 = (int)(valorTotal / 100);
            valorTotal %= 100;

            int notas50 = (int)(valorTotal / 50);
            valorTotal %= 50;

            int notas20 = (int)(valorTotal / 20);
            valorTotal %= 20;

            int notas10 = (int)(valorTotal / 10);
            valorTotal %= 10;

            int notas5 = (int)(valorTotal / 5);
            valorTotal %= 5;

            int notas2 = (int)(valorTotal / 2);
            valorTotal %= 2;

            // Moedas
            int moedas1 = (int)(valorTotal / 1);
            valorTotal %= 1;

            int moedas50 = (int)(valorTotal / 0.5);
            valorTotal %= 0.5;

            int moedas25 = (int)(valorTotal / 0.25);
            valorTotal %= 0.25;

            int moedas10 = (int)(valorTotal / 0.10);
            valorTotal %= 0.10;

            int moedas5 = (int)(valorTotal / 0.05);
            valorTotal %= 0.05;

            int moedas01 = (int)(valorTotal / 0.01);
            valorTotal %= 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(notas100 + " nota(s) de R$100.00");
            Console.WriteLine(notas50 + " nota(s) de R$50.00");
            Console.WriteLine(notas20 + " nota(s) de R$20.00");
            Console.WriteLine(notas10 + " nota(s) de R$10.00");
            Console.WriteLine(notas5 + " nota(s) de R$5.00");
            Console.WriteLine(notas2 + " nota(s) de R$2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moedas1 + " moeda(s) de R$1.00");
            Console.WriteLine(moedas50 + " moeda(s) de R$0.50");
            Console.WriteLine(moedas25 + " moeda(s) de R$0.25");
            Console.WriteLine(moedas10 + " moeda(s) de R$0.10");
            Console.WriteLine(moedas5 + " moeda(s) de R$0.05");
            Console.WriteLine(moedas01 + " moeda(s) de R$0.01");
        }
    }
}
