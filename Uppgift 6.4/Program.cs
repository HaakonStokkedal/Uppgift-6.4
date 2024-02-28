namespace Uppgift_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in basen:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in exponenten:");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produkten är {Potens(bas, exponent)}.");

            Console.ReadKey();
        }

        static double Potens(int bas, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else if (exponent == 1)
            {
                return bas;
            }
            else if (exponent > 1)
            {
                double svar = 1;
                for (int i = 0; i < exponent; i++)
                {
                    svar = svar * bas;
                }
                return svar;
            }

            return 0;
        }
    }
}