using BootCamp_Atividade_INHERITANCE_AND_POLYMORPHISM;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Employe> employe = new List<Employe>();

        Console.Write("How many employees do you want to calculate?: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Employe #{i}:");
            Console.Write("Outsourced (s/n)? ");
            char ch = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Hourly rate: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 's' || ch == 'S')
            {
                Console.Write("Additional: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employe.Add(new EmployeOutsourced(name, hours, valuePerHour, additionalCharge));
            }
            else
            {
                employe.Add(new Employe(name, hours, valuePerHour));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total payment: ");
        foreach (Employe emp in employe)
        {
            Console.WriteLine($"{emp.Name} - R$ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        Console.ReadKey();
    }
}