using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class Staff
    {
        private string _nameOfStaff;
        private const int _hourlyRate = 30;
        private Decimal _hoursWorked;

        public Decimal HoursWorked
        {
            get
            {
                return _hoursWorked;
            }
            set
            {
                if (value > 0)
                    _hoursWorked = value;
                else
                    _hoursWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public Decimal CalculatePay()
        {
            PrintMessage();

            if (_hoursWorked > 0)
                return _hoursWorked * _hourlyRate;
            else
                return 0;
        }

        public Decimal CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (_hoursWorked > 0)
                return _hoursWorked * _hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff=" + _nameOfStaff + "," +
                "Hourly Rate =" + _hourlyRate + "," + "," +
                "Hours Worked =" + _hoursWorked;
        }

        public Staff(string name)
        {
            _nameOfStaff = name;
            Console.WriteLine("\n" + _nameOfStaff);
            Console.WriteLine("------------------");
        }

        public Staff(string firstName, string lastName)
        {
            _nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + _nameOfStaff);
            Console.WriteLine("------------------");
        }
    }
}
