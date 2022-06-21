using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    class FunctionOverloading
    {
        private string _address;

        public string SetAddress(string country)
        {
            _address = country;
            return "Address added Successfully";
        }
        public bool SetAddress(string state,string country)
        {
            _address = state + " " + country;
            return true;
        }
        public void SetAddress(string city, string state,string country)
        {
            _address = city+ " " + state + " " +country;
            Console.WriteLine("Address added Successfully");
        }
    }
}
