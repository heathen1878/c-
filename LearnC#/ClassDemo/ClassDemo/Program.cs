using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal pay;

            Console.WriteLine("\n Staff name ?");
            string name = Console.ReadLine();
            Console.WriteLine("\n How many hours worked?");
            Decimal hoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n Bonus value");
            int bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Allowance value");
            int allowance = Convert.ToInt32(Console.ReadLine());

            Staff staffPay = new Staff(name);
            staffPay.HoursWorked = hoursWorked;

            if (bonus > 0 || allowance > 0)
            {
                pay = staffPay.CalculatePay(bonus, allowance);
            } 
            else
            {
                pay = staffPay.CalculatePay();
            }
            
            Console.WriteLine("Pay = {0}", pay);
                               
        }
    }
}
