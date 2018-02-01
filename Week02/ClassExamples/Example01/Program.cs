using System;

namespace Example01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "Centennial", -20, 40);

            double salary = employee1.Earnings(employee1.HourlyRate, employee1.HoursWorked);

            Console.WriteLine(" Constructor initialization Employee 01 - Salary: {0}", salary);

            employee1.EmployeeID = 123;
            employee1.EmployeeName = "Logan";
            employee1.HourlyRate = 50;
            employee1.HoursWorked = 40;
            //double salary = hourlyRate * hoursWorked;
            salary = employee1.Earnings(employee1.HourlyRate, employee1.HoursWorked);
            Console.WriteLine(" Employee 01 - Salary: {0}", salary);

            employee1.HourlyRate = -15;
            Console.WriteLine(" Employee 01 - Salary: {0}", employee1.Earnings(employee1.HourlyRate, employee1.HoursWorked));

            employee1.HoursWorked = 30;
            Console.WriteLine(" Employee 01 - Salary: {0}", employee1.Earnings(employee1.HourlyRate, employee1.HoursWorked));

            // create another object
            Employee employee2 = new Employee(200, "java", 20, 50);
            Console.WriteLine(" Constructor Employee 02 - Salary: {0}", employee2.Earnings(employee2.HourlyRate, employee2.HoursWorked));

            employee2.EmployeeID = 333;
            employee2.EmployeeName = "Kim";
            employee2.HourlyRate = 30;
            employee2.HoursWorked = 20;

            Console.WriteLine(" Employee 02 - Salary: {0}", employee2.Earnings(employee2.HourlyRate, employee2.HoursWorked));
        }// end main()

    }// end class
}// end namespace
