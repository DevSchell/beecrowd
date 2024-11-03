namespace GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto = int.Parse(Console.ReadLine()); // Em horas
            int velocidadeMedia = int.Parse(Console.ReadLine()); // Quantos quilômetros por hora o carro estava fazendo
            int kml = 12; // O carro faz 12km/l
            double distanciaPercorrida = tempoGasto * velocidadeMedia;
            double combustivelGasto = distanciaPercorrida / kml;

            Console.WriteLine(combustivelGasto.ToString("F3"));
        }
    }
}
