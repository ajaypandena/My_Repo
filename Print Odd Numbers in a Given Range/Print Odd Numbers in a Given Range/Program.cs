namespace Print_Odd_Numbers_in_a_Given_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x ;
            Console.WriteLine("Print_Odd_Numbers_in_a_Given_Range");
            IEnumerable<int> oodNums =  Enumerable.Range(20,20).Where (x  => x %2 !=0);

            foreach (int i in oodNums) 
            { 
             Console.WriteLine(i);
            }
            Console.WriteLine("praticing printing odd and even numbers");
            //Console.Read();

            Console.Write("Enter a number:");
            x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine("its an odd");
                Console.Read();
            }
            else
                Console.WriteLine("its an even");
            Console.Read();
        }
    }
}