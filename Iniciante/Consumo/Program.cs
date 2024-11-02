namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine()); combustivel = Math.Round(combustivel,1);

            double gasto = distancia / combustivel;

            Console.WriteLine(gasto.ToString("F3") + " km/l");
        }
    }
}
