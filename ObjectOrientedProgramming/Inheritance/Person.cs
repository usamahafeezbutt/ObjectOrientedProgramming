

namespace ObjectOrientedProgramming.Inheritance
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
