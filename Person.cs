using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Person
    {
        private string name;
        private int birthYear;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int BirthYear
        {
            set { birthYear = value; }
            get { return birthYear; }
        }
        public Person()
        {
            name = "ivan";
            birthYear = 2000;
        }
        public Person(string _name, int _birthYear)
        {
            name = _name;
            birthYear = _birthYear;
        }
        public int Age(int nowYear)
        {
            int age = nowYear - birthYear;
            return age;
        }
        public static Person Input()
        {
            Console.WriteLine("input the name of person ");
            string name = Console.ReadLine();
            Console.WriteLine("input the birthday year of person: ");
            int birthYear =  Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name , birthYear );
            return person;
        }
        public void ChangeName(string _Name)
        {
            name = _Name;
        }
        public override string ToString()
        {
            return "person's name " + name + "person's age " + Age(2022);
        }
        public void Output()
        {
            Console.WriteLine(" Person name: " + name + " ; person age: " + Age(2022));
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
