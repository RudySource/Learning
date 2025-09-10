// See https://aka.ms/new-console-template for more information

namespace MyNamespace;

internal class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            sum += i;
            Console.WriteLine(sum);
        }
    }
}