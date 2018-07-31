using System;
using System.Collections;


namespace TestOOPJuly2018
{
    public class Employee
    {
        #region Fields
        // Fields to represent the data (private)
        private string firstName;
        private string lastName;
        private float salary;
        private string bonus;
        private string ssn;
        private string address;
        #endregion

        // Properties to protect the fields + validation (use properties to access this data) (Regex)
        // Each property will be related to any of the above fields
        // design a method to return first name
        public string FirstName // like a method WITHOUT param parenthesis
        {
            set { firstName = value; } // value KEYWORD is a placeholder and will be changed with whatever the user provides
            get { return firstName; } // return first name variable NOT the FirstName method
        }
        public string LastName // like a method WITHOUT param parenthesis
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public float Salary // like a method WITHOUT param parenthesis
        {
            set { salary = value; }
            get { return salary; }
        }
        public string Bonus // like a method WITHOUT param parenthesis
        {
            set { bonus = value; }
            get { return bonus; }
        }
        public string SSN // like a method WITHOUT param parenthesis
        {
            set { ssn = value; }
            get { return ssn; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }


        // Constructors
        // Method used to initialize data; will have the same name as the Class name
        // can only be called when you create the object 
        // every class has a default Constructor: C# will write one for you


        // default constructor (no-argument constructor)
        public Employee()
        // says instead of putting blanks, put these initliazed variables in 
        {
            FirstName = "not assigned";
            LastName = "not assigned";
            Salary = 40000;
            SSN = "000-00-0000";
        }


        // Overloaded Constructor
        public Employee(string fn, string ln, float sal, string s) // this one specifies string input
        {
            // firstName = fn; <----- gives user access to the private var
            FirstName = fn;
            LastName = ln;
            Salary = sal;
            SSN = s;
            // fn = FirstName;  // logical error!! it's taking the user's input then assigning to the FirstName property
        }

        // Methods // ADDED VIRTUAL METHOD SO THAT THIS CAN ACCOMODATE CHANGE THAT'S NOT IN THE BASE METHOD
        public virtual void PrintInfo() //void because it just prints, doesn't take anything 
        {
            Console.WriteLine($"{LastName},{FirstName}, SSN: {SSN}, Salary: {Salary}");

        }
    }
}
