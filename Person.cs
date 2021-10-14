using System;
using System.Collections.Generic;
using System.Text;

namespace UMLDiagram
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }


        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Person()
        {
            Name = "";
            Address = "";
        }

        public override string ToString()
        {
            return $"Person[Name: {Name} Address: {Address}]";
        }
    }
}
