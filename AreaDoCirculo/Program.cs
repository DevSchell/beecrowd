﻿namespace AreaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double a = (raio * raio) * pi;
            Console.WriteLine("A=" + a.ToString("F4")); // Força o resultado a ser retornado com 4 casas decimais
        }
    }
}
