namespace Print_All_the_Multiples_of_17_which_are_Less_than_100
{
    internal class Program
    {
        public static void Main()
        {
            int a, i;
            Console.WriteLine("Multiples of 17 are : ");
            for (i = 1; i < 100; i++)
            {
                a = i % 17;
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}