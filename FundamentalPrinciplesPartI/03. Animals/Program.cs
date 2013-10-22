using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Frog[] frogs =
            {
                new Frog( 2, "Frog1", Sex.Female),
                new Frog( 8, "Frog2", Sex.Male),
                new Frog( 6, "Frog3", Sex.Female),
                new Frog( 7, "Frog4", Sex.Male)
            };

        Dog[] dogs =
            {
                new Dog( 4, "Dog1", Sex.Male),
                new Dog( 7, "Dog2", Sex.Female),
                new Dog( 8, "Dog3", Sex.Male),
                new Dog( 10, "Dog4",Sex.Male)
            };

        Cat[] cats =
            {
                new Kitten( 3, "Cat1"),
                new Tomcat( 5, "Cat2"),
                new Kitten( 2, "Cat3"),
                new Tomcat( 1, "Cat4")
            };

        frogs[0].MakeSound();
        dogs[0].MakeSound();
        cats[0].MakeSound();

        Console.WriteLine("Average age of dogs " + Animal.AverageAge(dogs));
        Console.WriteLine("Average age of frogs " + Animal.AverageAge(frogs));
        Console.WriteLine("Average age of cats " + Animal.AverageAge(cats));
    }
}