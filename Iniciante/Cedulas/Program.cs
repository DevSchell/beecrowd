namespace Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorInicial = int.Parse(Console.ReadLine());
            int valor = valorInicial;

            int cedulas100 = valor / 100;
            valor = valor % 100;

            int cedulas50 = valor / 50;
            valor = valor % 50;

            int cedulas20 = valor / 20; 
            valor = valor % 20;

            int cedulas10 = valor / 10;
            valor = valor % 10;

            int cedulas5 = valor / 5;
            valor = valor % 5;

            int cedulas2 = valor / 2;
            valor = valor % 2;

            int cedulas1 = valor / 1;
            valor = valor % 1;

            Console.WriteLine(valorInicial);
            Console.WriteLine(cedulas100 + " nota(s) de R$100,00");
            Console.WriteLine(cedulas50 + " nota(s) de R$50,00");
            Console.WriteLine(cedulas20 + " nota(s) de R$20,00");
            Console.WriteLine(cedulas10 + " nota(s) de R$10,00");
            Console.WriteLine(cedulas5 + " nota(s) de R$5,00");
            Console.WriteLine(cedulas2 + " nota(s) de R$2,00");
            Console.WriteLine(cedulas1 + " nota(s) de R$1,00");
        }
    }
}
