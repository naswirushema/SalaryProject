using System;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int id;
            string name;
            string position;
            string gender;

            //   EmployeesSalary cal = new EmployeesSalary();

            Console.WriteLine("please enter your id number");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your name please");
            name = Console.ReadLine();
            Console.WriteLine("what is your position");
            position = Console.ReadLine();
            Console.WriteLine("what is your gender");
            gender = Console.ReadLine();
            EmployeesSalary cal = new EmployeesSalary(id, name, position, gender);
            Console.WriteLine("enter the gross salary");
            double grossSalary;
            grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what type of employee are you? 1=monthly, 2=one time, 3= hourly");
            int type;
            type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine(
                    $"{cal.Name} your monthly salary on position of {cal.Position}   is {cal.MonthlySalary(grossSalary)}");

            }
            else if (type == 2)
            {

                Console.WriteLine(
                    $"{cal.Name} your one-time salary on position of {cal.Position} is {cal.OneTimeSalary(grossSalary)}");
            }
            else if (type == 3)
            {


                Console.WriteLine("how many hours have you worked? ");
                double hours;


                hours = Convert.ToDouble(Console.ReadLine());
                if (hours > 0)
                {
                    Console.WriteLine($"{cal.Name} Your hourly salary is {cal.HourlySalary(grossSalary, hours)}");
                }
                else
                {
                    Console.WriteLine(" Your hourly salary is 0");
                }





            }
        }
    }
}