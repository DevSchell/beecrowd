namespace Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            nota1 = Math.Round(nota1,2);
            double nota2 = double.Parse(Console.ReadLine());
            nota2 = Math.Round(nota2,2);

            double MEDIA = ((nota1 * 3.5) + (nota2 * 7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}
