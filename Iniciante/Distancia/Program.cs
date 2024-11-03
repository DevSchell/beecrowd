namespace Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            int velocidadeTempo = 2; // 1km a cada 2 minutos

            Console.WriteLine(km*velocidadeTempo + " minutos");
        }
    }
}
