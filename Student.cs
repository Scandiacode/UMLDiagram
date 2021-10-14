using System;
using System.Collections.Generic;
using System.Text;

namespace UMLDiagram
{
    class Student : Person
    {

        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public Student() : base()
        {
            Program = "";
            Year = 0;
            Fee = 0;
        }


        public override string ToString()
        {
            return $"Student[{base.ToString()},Program= {Program} , Year= {Year} , Fee={Fee}]";
        }
    }
}
