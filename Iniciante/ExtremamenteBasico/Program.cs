namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler 2 valores inteiros, guardar em variáveis A e B, atribuir resultado da soma de A e B em variável X
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X = A + B;
            Console.WriteLine("X = " + X);
        }
    }
}
