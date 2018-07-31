using System;
namespace TestOOPJuly2018
{
    public class Teacher : Employee // inheritance from Employee class! private fields will not though. if no inheritance, would have to retype all 
    {
        // fields (private)
        private float bonus;

        // properties
        public float Bonus
        {
            set { bonus = value; }
            get { return Bonus; }
        }

        // constructors 
        public Teacher() //default; no params
        {
            bonus = 2000; // initialize bonus
        }

        // overload constructor
        public Teacher(string fn, string ln, float sal, string s, int b)
            :base(fn,ln,sal,s) // call constructor from Base Class and just adding the Bonus; using keyword Base
            // takes and passes through
        {
            // first name, last name, salary and ssn are being reused from employee constructor 
            //FirstName = fn;
            //LastName = ln;
            //Salary = sal;
            //SSN = s;

            // initialize the new one NOT on the Teacher base class
            Bonus = b;
        }
        // methods
        public override void PrintInfo()
        {
            // other FirstName, LastName, Salary, SSN 
            base.PrintInfo();
            Console.WriteLine($"Bonus: {Bonus}"); // code that is added from the original Base PrintInfo() Method
        }

    }        
 }

