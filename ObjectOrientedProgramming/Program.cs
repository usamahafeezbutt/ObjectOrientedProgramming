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
            Console.WriteLine("\nExample of Encapsulation");
            Employee john = new("John", 10000, "Software Engineer");
            Employee sam = new("Sam", 12000, "Senior Software Engineer");
            john.EmployeeDetails();
            sam.EmployeeDetails();
            john.UpdateEmployeeDetails("Senior Software Engineer", 12000);
            john.EmployeeDetails();

            //Inheritance Example
            Console.WriteLine("\nExample of Inheritance");
            Student student = new("Sam", 24, "Rawalpindi", 10000);
            Teacher teacher = new("John", 24, "Rawalpindi", 50000, new List<string> { "Computer", "DevOps" });
            Accountant accountant = new("Eddie", 24, "Rawalpindi", 90000);
            student.ShowFee();
            teacher.ShowCourses();
            accountant.ManagePayRoll();

            //Abstraction Examples without Abstract class or Interface
            Console.WriteLine("\nAbstraction Examples without Abstract class or Interface ");
            Employee johny = new("Johny", 10000, "Software Engineer");
            john.EmployeeDetails();
            john.UpdateEmployeeDetails("Senior Software Engineer", 12000);

            //Abstraction Using Abstract Classes
            Console.WriteLine("\nAbstraction Example using Abstract class");
            ApplicationUser abstractAdmin = new Admin();
            ApplicationUser abstractMember = new Member();
            if (abstractAdmin.RegisterUser("Add new user here")) Console.WriteLine("Admin Registered Successfully");
            if (!string.IsNullOrEmpty(abstractAdmin.LoginUser("Username", "Password"))) Console.WriteLine("Admin Logged In Successfully");
            if (abstractMember.RegisterUser("Add new user here")) Console.WriteLine("Member Logged In Successfully");
            if (!string.IsNullOrEmpty(abstractMember.LoginUser("Username", "Password"))) Console.WriteLine("Admin Logged In Successfully");


            //Abstraction Using Interfaces
            Console.WriteLine("\nAbstraction Example using Interface");
            IApplicationUser admin = new Admin();
            IApplicationUser member = new Member();
            if(admin.RegisterUser("Add new user here")) Console.WriteLine("Admin Registered Successfully");
            if(!string.IsNullOrEmpty(admin.LoginUser("Username", "Password"))) Console.WriteLine("Admin Logged In Successfully");
            if(member.RegisterUser("Add new user here")) Console.WriteLine("Member Logged In Successfully");
            if(!string.IsNullOrEmpty(member.LoginUser("Username", "Password"))) Console.WriteLine("Admin Logged In Successfully");

            //Static or Compile-Time Polymorphism
            Console.WriteLine("\nExample of Static or Compile-Time Polymorphism ");
            FunctionOverloading function = new();
            Console.WriteLine(function.SetAddress("Pakistan"));
            Console.WriteLine(function.SetAddress("Punjab", "Pakistan"));
            function.SetAddress("Rawalpindi", "Punjab", "Pakistan");

            //Dynamic or Run-Time Polymorphism
            Console.WriteLine("\nExample of Dynamic or Run-Time Polymorphism ");
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
            Console.WriteLine("\nExample of Method Hiding");
            Vehicle car = new();
            Van van = new();
            Console.WriteLine("CarbonFootPrint of Car {0}", car.CarbonFootPrint(2));
            van.CarbonFootPrint(2);

        }
    }
}
