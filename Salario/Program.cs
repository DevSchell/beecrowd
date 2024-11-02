namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funcionarioNumero = int.Parse(Console.ReadLine());
            int funcionarioHoras = int.Parse(Console.ReadLine());
            double funcionarioValorHora = double.Parse(Console.ReadLine());
            funcionarioValorHora = Math.Round(funcionarioValorHora,2);

            double salario = funcionarioHoras * funcionarioValorHora;

            Console.WriteLine("NUMBER = " + funcionarioNumero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
