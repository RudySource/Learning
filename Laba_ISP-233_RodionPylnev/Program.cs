// See https://aka.ms/new-console-template for more information
namespace Laba_ISP233_RodionPylnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine();
            Console.WriteLine($"{name},  {age}, {city}");
        }
    }
}
