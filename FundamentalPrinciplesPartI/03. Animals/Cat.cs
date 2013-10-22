using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cat : Animal
{
    public Cat(int age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Myauu!");
    }
}