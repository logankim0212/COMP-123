using System;
namespace Exercise02
{
    abstract class Salesperson
    {
        // properties
        private string FirstName { get; set; }
        private string LastName { get; set; }

        // constructors
        public Salesperson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        } // end constructors

        // method for full name
        public string Fullname()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        } // end Fullname

        // displaying datas
        public override string ToString()
        {
            return string.Format("First Name: {0} \nLast Name: {1}", FirstName, LastName);
        } // end ToString
    } // end class
} // end namespace
