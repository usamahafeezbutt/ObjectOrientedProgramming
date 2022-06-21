using System;

namespace ObjectOrientedProgramming.Inheritance
{
    class Student : Person
    {
        private double _fee;
        public Student(string name, int age, string address, double fee) : base(name, age, address)
        {
            _fee = fee;
        }

        public void ShowFee()
        {
            Console.WriteLine($"Fee submitted by student is {_fee}");
        }
    }
}
