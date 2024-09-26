using System.Runtime.InteropServices;

namespace exercico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o 1° numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o 2° numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o 3° numero: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o 4° numero: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O RESULTADO DA SOME É: " + (n1 + n2 + n3 + n4));

            Console.ReadKey();
        }
    }
}
