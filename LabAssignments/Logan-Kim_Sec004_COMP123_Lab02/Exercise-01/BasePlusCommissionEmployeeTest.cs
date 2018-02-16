using System;
/* Create a BasePlusCommissionEmployee class (BasePlusCommissionEmployee.cs)
 * that has the following instance variables:
 *      -   Employee ID, First name, last name,  base salary, gross sales
 *          (amount in dollars) and commission rate.Define their data types
 *          appropriately.
 *      -   Define only property getters for employee ID, first name, last name
 *          and base salary. Ensure the proper ( no negative and null values )
 *          data values by implementing data validations.
 *      -   Use default value of 200.00 dollars for base salary for all the
 *          employees.
 *      -   Define property getter and setter for gross sales and commission
 *          rate.Ensure the values for them should never be negative or zero.
 *      -   Commission rate should be between 0.1 and 1.0%. Set default value
 *          to 0.1.
 *      -   Class should have defined two overloaded constructors:
 *              o One for initializing all the instance data members
 *              o Second for initializing employee ID, first name, base salary
 *                only.
 *      -   Define a public method -  double earnings() which calculates
 *          employee's commission ( commission rate * gross sales + base salary )
 *      -   Define a public method - String toString() which is used to display
 *          the object's data
 */
namespace Exercise01
{
    class BasePlusCommissionEmployee
    {
        // Instant data members
        private double grossSales;
        private double commissionRate = 0.1;
        private double baseSalary = 200;

        // Auto-implemented read-only property
        public string EmployeeID { get; }
        public string FirstName { get; }
        public string LastName { get; }

        // Property for base salary
        public double BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
        } // end property

        // Property for gross sales
        public double GrossSales
        {
            get
            {
                return grossSales;
            } // end get
            set
            {
                if (value > 0)
                    grossSales = value;
            } // end set
        } // end property

        // Property for commission rate
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                if (value > 0.1 && value <= 1.0)
                    commissionRate = value;
            } // end set
        } // end property

        // Constructor with all datas
        public BasePlusCommissionEmployee(string firstName, string lastName,
                                          string employeeID, double baseSalary,
                                          double grossSales, double commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeID;
            this.baseSalary = baseSalary;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        } // end constructor

        // Constructor with datas (First Name, Base Salary, Employee ID)
        public BasePlusCommissionEmployee(string firstName, double baseSalary,
                                          string employeeID)
        {
            
            FirstName = firstName;
            this.baseSalary = baseSalary;
            EmployeeID = employeeID;
        } // end constructor

        // Method for earnings
        public double earnings()
        {
            return GrossSales * CommissionRate / 100 + BaseSalary;
        } // end method

        // Method for displaying datas
        public override string ToString()
        {
            // Checking if employee ID is int
            int intEmployeeID = 0;
            bool num = Int32.TryParse(EmployeeID, out intEmployeeID);

            // Print error conditions
            if (FirstName.Length == 0)
            {
                return string.Format("You didn't enter the first name.");
            } // end if
            if (LastName.Length == 0)
            {
                return string.Format("You didn't enter the last name.");
            } // end if
            if (EmployeeID.Length == 0 || intEmployeeID < 0)
            {
                return string.Format("You didn't enter the appropriate employee ID.");
            } // end if
            if (BaseSalary < 0)
            {
                return string.Format("The base salary cannot be negative.");
            } // end if
            if (GrossSales <= 0)
            {
                return string.Format("The gross sales cannot be negative or zero.");
            }// end if
            if (CommissionRate <= 0.1 || CommissionRate > 1.0)
            {
                return string.Format("Commission rate should be between 0.1 and 1.0%.");
            } // end if
            // end print error conditions

            return string.Format("First Name: {0} \nLast Name: {1} \nEmployee" +
                                 " ID: {2} \nBase Salary: {3:C} \nGross Sales:" +
                                 " {4:C} \nCommission Rate: {5}%", FirstName,
                                 LastName, EmployeeID, BaseSalary, GrossSales,
                                 CommissionRate);
        } // end method
    } // end class
} // end namespace
