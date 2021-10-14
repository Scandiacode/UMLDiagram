using System;
using System.Collections.Generic;

namespace UMLDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>
            { 
                new Student("Justin","Commerce Township","Criminal Justice", 4 , 70000 ),
                new Student("Andrew" , "Oxford" , "Engineering" , 4 , 60000),
                new Student("Nate" , "Troy" , "Front-End Java", 1 , 9500),
                new Staff("Mr.Kenrick", "Walled Lake", "St. Mary's Prep", 45000.50),
                new Staff("Mr.Schop", "Waterford" , "St. Mary's Prep" , 45000.50)
            };

            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

            /*
            Person p = new Person("Mr.Kenrick", "Walled Lake");
            Console.WriteLine(p.ToString());

            Student s = new Student("Nate", "Troy", "Grand Circus", 1, 9500);
            Console.WriteLine(s.ToString());

            Staff st = new Staff("Mr.Schop", "Waterford", "St. Mary's Prep", 45000.50);
            Console.WriteLine(st.ToString());

            Person p1 = new Person();
            Console.WriteLine(p1.ToString());

            Student s1 = new Student();
            Console.WriteLine(s1.ToString());

            Staff st1 = new Staff();
            Console.WriteLine(st1.ToString());
            */
        }
    }
}