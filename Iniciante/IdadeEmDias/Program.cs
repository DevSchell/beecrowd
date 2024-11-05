namespace IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeDias = int.Parse(Console.ReadLine());

            int ano = idadeDias / 365; // Qtd de anos
            idadeDias -= ano * 365;

            int meses = idadeDias / 30; // Qtd meses
            idadeDias -= meses * 30;

            int dias = idadeDias;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
