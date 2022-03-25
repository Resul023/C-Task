using System;

namespace _24Mart_Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your HourPay:");
            int hourPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your MonthlyWorkHour:");
            int monthlyWorkHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Write your surname:");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Write your age");
            int age = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                
                if (age >17)
                {
                    break;
                }
                else if (age<17)
                {
                    Console.WriteLine("Your age is not enough.You should 18 at least for work");
                    age = Convert.ToInt32(Console.ReadLine());
                }
            }

            Worker workerOne = new Worker(hourPay, monthlyWorkHour,name,surname,age);
            
            Console.WriteLine($"Salary-{workerOne.Salary(hourPay, monthlyWorkHour)} Name-{name} Surname-{surname} Age-{age}");
        }
    }
}
