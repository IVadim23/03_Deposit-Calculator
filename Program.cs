using System;

namespace 03_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Add term: ");
            int term = int.Parse(Console.ReadLine());
            Console.WriteLine("Add rate: " );
            double rate = double.Parse(Console.ReadLine());
            double sum = deposit + term * ((deposit * rate / 100) / 12);
            Console.WriteLine("The final sum is equal to: \n {0:f2}",sum);
        }
    }
}
