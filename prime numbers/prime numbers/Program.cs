namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int x;
            Console.WriteLine("Enter Number to check Prime Number : ");
            x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}