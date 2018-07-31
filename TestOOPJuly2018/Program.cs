using System;
using System.Collections.Generic;

namespace TestOOPJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            // List of Employees
            // like a data entry program where you can add as many employees as you want 
            List<Employee> employees = new List<Employee>(); //use the class Employees with the objects associated 

            Employee s1 = new Employee("Damien", "Rocchi", 15000000, "xxx-xx-xxxx"); // uses constructors build in the Employee Class

            // without constructor 
            Employee s2 = new Employee();
            s2.FirstName = "Damien";
            s2.LastName = "Rocchi";
            s2.Salary = 1500000;
            s2.SSN = "xxx-xx-xxxx";


            //used to add new employees to the list
            while(true) // made an object
            {
                Employee temp = new Employee(); // make the object then modify based on the input
                Console.WriteLine("Please provide the First Name:");
                temp.FirstName = Console.ReadLine(); // temporary 

                Console.WriteLine("Please provide the Last Name:");
                temp.LastName = Console.ReadLine();

                Console.WriteLine("Please provide the SSN:");
                temp.SSN = Console.ReadLine();

                Console.WriteLine("Please provide the Salary:");
                temp.Salary = float.Parse(Console.ReadLine());

                employees.Add(temp); // add the temp object to the employees list 

                Console.WriteLine("Do you want to add more employees?");
                string choice = Console.ReadLine();
                if (choice == "N")
                    break;
                // if you want to add new info, you need to create a new object and set values
            }

            // you want print all employees
            foreach (Employee e in employees) //e is a variable // gets from list!
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
                Console.WriteLine("======================");

            }

            // DOES THE SAME THING
            //for (int i = 0; i < employees.Count; i++)  // pulls the info
            //{
            //    Console.WriteLine($"{employees[i]} {employees[i].LastName}");
            //    Console.WriteLine("======================");
            //}





            //Employee john = new Employee(); // object and tells how it will behave 

            //john.FirstName = "John"; // sets first "John" || then gets as your value

            //Console.WriteLine(john.FirstName); // use get because you're trying to print what's already been set

            //john.Salary = 5000; // set 

            //john.Salary = john.Salary + 1000; // get set; getting the value, adding 1000 to it then setting it 

            //Console.WriteLine(john.SSN); // cannot access. with a string the default value.. will print blank
            // properties have defaults if not provided; string = blank; int = 0; bool = false

            ////////////////////

           




        }
    }
}


