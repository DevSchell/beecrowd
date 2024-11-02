namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            nota1 = Math.Round(nota1,1);

            double nota2 = double.Parse(Console.ReadLine());
            nota2 = Math.Round(nota2,1);

            double nota3 = double.Parse(Console.ReadLine());
            nota3 = Math.Round(nota3,1);

            double media = ((nota1*2) + (nota2*3) + (nota3*5)) / (2 + 3 + 5);
            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}
