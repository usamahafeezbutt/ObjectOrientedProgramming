using System;

namespace ObjectOrientedProgramming.Encapsulation
{
    class Employee
    {
        //Encapsulation started by restricting properties to be private
        private string _name;
        private double _salary;
        private string _designation;

        public Employee(string name, double salary, string designation)
        {
            _name = name;
            _salary = salary;
            _designation = designation;
        }

        //Updated the values of private properties using public function
        public bool UpdateEmployeeDetails(string newDesignation, double newSalary)
        {
            ValidateEmployeeDetails(newDesignation, newSalary);
            _designation = newDesignation;
            _salary = newSalary;
            ShowUpdatedEmployeeDetails();
            return true;
        }

        //internal method to validate details of employee
        private bool ValidateEmployeeDetails(string designation, double salary)
            => true;

        //internal method to show updated details 
        private void ShowUpdatedEmployeeDetails()
        {
            Console.WriteLine($"{_name} is a {_designation} and getting {_salary} salary ");
        }

        //Access and show details of employee 
        public void EmployeeDetails()
        {
            Console.WriteLine($"{_name} is a {_designation} and getting {_salary} salary ");
        }
    }
}
