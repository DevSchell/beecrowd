namespace SalarioComBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string funcNome = Console.ReadLine();

            double funcSalario = double.Parse(Console.ReadLine());
            funcSalario = Math.Round(funcSalario,2);

            double funcVendas = double.Parse(Console.ReadLine());
            funcVendas = Math.Round(funcVendas,2);

            double SalTotal = ((funcVendas * 15) / 100) + funcSalario;

            Console.WriteLine("TOTAL = R$ " + SalTotal.ToString("F2"));
        }
    }
}
