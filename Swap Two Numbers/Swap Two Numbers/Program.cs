namespace Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num1, num2,  temp;
            Console.Write("\nEnter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nafter swapping");
            Console.WriteLine("\nfirst number" + num1);
            Console.WriteLine("second number" + num2);
            Console.Read();
        }
    }
}