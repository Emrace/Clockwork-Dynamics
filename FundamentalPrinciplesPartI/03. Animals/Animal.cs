using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Sex
{
    Male,
    Female
}

public abstract class Animal : ISound
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Sex Sex { get; set; }

    public abstract void MakeSound();

    public static int AverageAge(Animal[] animals)
    {
        int collectiveAge = 0;

        foreach (var animal in animals)
        {
            collectiveAge += animal.Age;
        }

        return collectiveAge / animals.Length;
    }
}