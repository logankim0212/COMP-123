using System;
namespace Example01
{
    public class Employee
    {
        // instance data members
        private int employeeID;
        private string employeeName;
        private double hourlyRate;
        private double hoursWorked;

        //Properties for employeeID
        public int EmployeeID
        {
            get //getter
            {
                return employeeID;
            }
            set //setter
            {
                employeeID = value;
            }
        }
        //end properties

        //Properties for employeename
        public string EmployeeName
        {
            get //getter
            {
                return employeeName;
            }
            set //setter
            {
                employeeName = value;
            }
        }
        //end properties

        //Properties for hourlyRate
        public double HourlyRate
        {
            get //getter
            {
                return hourlyRate;
            }
            set //setter
            {
                if (value > 0)
                {
                    hourlyRate = value;
                }
                else
                {
                    hourlyRate = 0;
                }
            }
        }
        //end properties

        //Properties for hoursWorked
        public double HoursWorked
        {
            get //getter
            {
                return hoursWorked;
            }
            set //setter
            {
                if (value > 0)
                {
                    hoursWorked = value;
                }
                else
                {
                    hoursWorked = 0;
                }
            }
        }
        //end properties

        //Constructors
        public Employee(int empID, string name, double rate, double hours)
        {
            EmployeeID = empID;
            EmployeeName = name;
            HourlyRate = rate;
            HoursWorked = hours;
        }

        //constructors can be overloaded
        public Employee(int empID, string name)
        {
            EmployeeID = empID;
            EmployeeName = name;
        }

        // Method to calculate salary
        public double Earnings(double rate, double hours)
        {
            return rate * hours;
        }
    }// end class
}// end namespace
