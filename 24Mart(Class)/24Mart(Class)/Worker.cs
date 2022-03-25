using System;
using System.Collections.Generic;
using System.Text;

namespace _24Mart_Class_
{
    class Worker:Person
    {
        public Worker(int hourpay, int monthlyworkhour,string name, string surname, int age):base(name,surname,age)
        {
            this.HourPay = hourpay;
            this.MonthlyWorkHour = monthlyworkhour;
        }

        public int HourPay;
        public int MonthlyWorkHour;

        public int Salary(int HourPay, int MonthlyWorkHour) 
        {
            int Salary = HourPay * MonthlyWorkHour;
            return Salary;
        }
      
    }
}
