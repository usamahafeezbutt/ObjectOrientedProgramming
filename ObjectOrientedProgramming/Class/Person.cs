

using System;

namespace ObjectOrientedProgramming.Classes
{
    internal class Person
    {
        private string _name;
        private double _height;
        private double _speed;

        public Person(string name, double height, double speed)
        {
            _name = name;
            _height = height;
            _speed = speed;
        }

        public void Run()
        {
            Console.WriteLine($"{_name} {_height} in height runs at {_speed}");
        }
    }
}
