namespace ConversaoDeTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSegundos = int.Parse(Console.ReadLine());

            int horas = totalSegundos / 3600;          // Passo 1
            int sobra = totalSegundos % 3600;

            int minutos = sobra / 60;                  // Passo 2
            int segundos = sobra % 60;                 // Passo 3

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
