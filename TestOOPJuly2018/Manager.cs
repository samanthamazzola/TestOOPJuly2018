using System;
namespace TestOOPJuly2018
{
    public class Manager : Employee
    {
        // fields 
        private int timeOff;

        // properties
        public int TimeOff
        {
            set { timeOff = value; }
            get { return timeOff; }
        }

        // default constructors //reuse constructor code from Base Class.... Calls the info from the Base, then initializes new "timeOff"
        public Manager() // :base()
        {
            timeOff= 30;
        }

        // overload constructor
        public Manager(string fn,string ln,float sal,string s, int tOff)
            :base(fn, ln, sal, s)
        {
            TimeOff = tOff;
        }

        // methods
        public override void PrintInfo()
        {
            // base.PrintInfo();
            // Console.WriteLine($"Time Off: {TimeOff}");

            Console.WriteLine($"Hey, I am a manager: My name is {FirstName}, {LastName}");
        }
    }
}
