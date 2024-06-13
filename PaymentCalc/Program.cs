using BootCamp_Atividade_INHERITANCE_AND_POLYMORPHISM;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionario = new List<Funcionario>();

        Console.Write("Quantos funcionários deseja calcular?: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Funcionario #{i}:");
            Console.Write("Terceirizado (s/n)? ");
            char ch = char.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Horas: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 's' || ch == 'S')
            {
                Console.Write("Adicional: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.Add(new FuncionarioTerceirizado(name, hours, valuePerHour, additionalCharge));
            }
            else
            {
                funcionario.Add(new Funcionario(name, hours, valuePerHour));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pagamento total: ");
        foreach (Funcionario emp in funcionario)
        {
            Console.WriteLine($"{emp.Nome} - R$ {emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}