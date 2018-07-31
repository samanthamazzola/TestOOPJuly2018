using System;
namespace TestOOPJuly2018
{
    public class TA : Employee
    {
        // field
        private int workLoad;

        // properties
        public int Workload
        {
            set { workLoad = value; }
            get { return Workload; }
        }

        // default constructor
        public TA():base()
        {
            workLoad = 60;
        }

        // overload constructor
        public TA(string fn, string ln, float sal, string s, int w)
            :base(fn, ln, sal, s)
        {
            Workload = w;
        }

        // method
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Hours of work: {Workload}");
        }
    }
}
