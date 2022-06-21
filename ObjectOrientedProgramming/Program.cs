using ObjectOrientedProgramming.Abstraction;
using ObjectOrientedProgramming.Encapsulation;
using ObjectOrientedProgramming.Inheritance;
using ObjectOrientedProgramming.Polymorphism;
using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation Example
            Console.WriteLine("\n\nExample of Encapsulation\n\n");
            Employee john = new("John", 10000, "Software Engineer");
            Employee sam = new("Sam", 12000, "Senior Software Engineer");
            john.EmployeeDetails();
            sam.EmployeeDetails();
            john.UpdateEmployeeDetails("Senior Software Engineer", 12000);
            john.EmployeeDetails();

            //Inheritance Example
            Console.WriteLine("\n\nExample of Inheritance\n\n");
            Student student = new("Sam", 24, "Rawalpindi", 10000);
            Teacher teacher = new("John", 24, "Rawalpindi", 50000, new List<string> { "Computer", "DevOps" });
            Accountant accountant = new("Eddie", 24, "Rawalpindi", 90000);
            student.ShowFee();
            teacher.ShowCourses();
            accountant.ManagePayRoll();

            //Abstraction Examples without Abstract class or Interface
            Console.WriteLine("\n\nAbstraction Examples without Abstract class or Interface \n\n");
            Employee johny = new("Johny", 10000, "Software Engineer");
            john.EmployeeDetails();
            john.UpdateEmployeeDetails("Senior Software Engineer", 12000);

            //Abstraction Using Abstract Classes
            Console.WriteLine("\n\nAbstraction Example using Abstract class\n\n");
            ApplicationUser abstractAdmin = new Admin();
            ApplicationUser abstractMember = new Member();
            abstractAdmin.RegisterUser("Add new user here");
            abstractAdmin.LoginUser("Username", "Password");
            abstractMember.RegisterUser("Add new user here");
            abstractMember.LoginUser("Username", "Password");

            //Abstraction Using Interfaces
            Console.WriteLine("\n\nAbstraction Example using Interface\n\n");
            IApplicationUser admin = new Admin();
            IApplicationUser member = new Member();
            admin.RegisterUser("Add new user here");
            admin.LoginUser("Username", "Password");
            member.RegisterUser("Add new user here");
            member.LoginUser("Username", "Password");

            //Static or Compile-Time Polymorphism
            Console.WriteLine("\n\nExample of Static or Compile-Time Polymorphism \n\n");
            FunctionOverloading function = new();
            Console.WriteLine(function.SetAddress("Pakistan"));
            Console.WriteLine(function.SetAddress("Punjab", "Pakistan"));
            function.SetAddress("Rawalpindi", "Punjab", "Pakistan");

            //Dynamic or Run-Time Polymorphism
            Console.WriteLine("\n\nExample of Dynamic or Run-Time Polymorphism \n\n");
            Vehicle vehicle = new();
            Vehicle dieselVehicle = new DieselVehicle();
            Vehicle hybridVehicle = new HybridVehicle();
            Vehicle electricVehicle = new ElectricVehicle();
            Console.WriteLine("CarbonFootPrint is: " + vehicle.CarbonFootPrint(1000));
            Console.WriteLine("CarbonFootPrint of Diesel Vehicle is: " +
            dieselVehicle.CarbonFootPrint(1000));
            Console.WriteLine("CarbonFootPrint Hybrid Vehicle is: " +
            hybridVehicle.CarbonFootPrint(1000));
            Console.WriteLine("CarbonFootPrint Electric Vehicle is: " +
            electricVehicle.CarbonFootPrint(1000));

            //Method Hiding
            Console.WriteLine("\n\nExample of Method Hiding\n\n");
            Vehicle van = new Van();
            van.CarbonFootPrint(50);

        }
    }
}
