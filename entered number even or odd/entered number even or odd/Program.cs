namespace entered_number_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a Number:");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine($"Entered number {i} is Even ");
                Console.Read();
            }
            else
            {
                Console.WriteLine($"Entered number {i} is Odd");
                Console.Read();
            }



        }
    }
}