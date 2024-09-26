namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("digite o primeiro numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digitar o segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("o valor da soma é: " + (numero1 + numero2));
            Console.WriteLine("o valor da subtração é: " + (numero1 - numero2));
            Console.WriteLine("o valor da multiplicação é: " + (numero1 * numero2));
            Console.WriteLine("o valor da divisão é: " + (numero1 / numero2));

            //Convert.ToInt32(Console.ReadLine()); serve para converter string em inteiro

            Console.ReadKey();
        }
    }
}
