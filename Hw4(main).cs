using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            for (int i=0; i<6; i++)
            {
                people[i] = Person.Input();
            }
            for (int i = 0; i < 6; i++)
            {
                people[i].Output();
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                if (people[i].Age(2022) <= 16)
                {
                    people[i].ChangeName("Very yung");
                     
                }
                people[i].Output();
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j <6; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[i]} and {people[j]} have the same names");
                    }
                    else
                    { Console.WriteLine($"Person's names are not equals"); }
                }
            }
        }
    }
}
