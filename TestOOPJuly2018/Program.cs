using System;
using System.Collections.Generic;

namespace TestOOPJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //objects
            Employee e1 = new Employee("Adam", "David", 5000, "323-23-2323");

            Teacher t1 = new Teacher("David","Wolverton ",700000,"122-12-1232",2000);
            // t1.PrintInfo(); // printing the info from Teacher class, BUT won't include the bonus because that's not in the Base class's PrintInfo() method

            Manager m1 = new Manager("Charlene", "Donelson", 5000, "234 - 43 - 2342", 10);

            // because a manager is also and employee you can print from this list info
            // Employee e2 = new Manager();

            // polymorphism exm; in curly bracket those are the obejcts
            List<Employee> gcList = new List<Employee>() { t1, e1, m1 }; // different objects of different types, saved in a list of a certain type


            //foreach(Employee emp in gcList) // all are given the same emp.PrintInfo() command
            //{
            //    emp.PrintInfo();
            //}

            foreach(Teacher t in gcList)
            {
                t.PrintInfo();
            }


            //// List of Employees
            //// like a data entry program where you can add as many employees as you want 
            //List<Employee> employees = new List<Employee>(); //use the class Employees with the objects associated 

            //Employee s1 = new Employee("Damien", "Rocchi", 15000000, "xxx-xx-xxxx"); // uses constructors build in the Employee Class

            //// without constructor 
            //Employee s2 = new Employee();
            //s2.FirstName = "Damien";
            //s2.LastName = "Rocchi";
            //s2.Salary = 1500000;
            //s2.SSN = "xxx-xx-xxxx";


            ////used to add new employees to the list
            //while(true) // made an object
            //{
            //    Console.WriteLine("Please provide the First Name:");
            //    string FirstName = Console.ReadLine(); // temporary 

            //    Console.WriteLine("Please provide the Last Name:");
            //    string LastName = Console.ReadLine();

            //    Console.WriteLine("Please provide the SSN:");
            //    string SSN = Console.ReadLine();

            //    Console.WriteLine("Please provide the Salary:");
            //    float Salary = float.Parse(Console.ReadLine());

            //    Employee temp = new Employee(FirstName,LastName,Salary,SSN); // using constructor instead of doing temp list and changing 
            //    employees.Add(temp); // add the temp object to the employees list

            //    Console.WriteLine("Do you want to add more employees?");
            //    string choice = Console.ReadLine();
            //    if (choice == "N")
            //        break;
            //    // if you want to add new info, you need to create a new object and set values
            //}

            //// you want print all employees
            //foreach (Employee e in employees) //e is a variable // gets from list!
            //{
            //    Console.WriteLine($"{e.FirstName} {e.LastName}");
            //    Console.WriteLine("======================");

            //}

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


