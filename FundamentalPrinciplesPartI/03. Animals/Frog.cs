using System;

public class Frog : Animal
{
    public Frog(int age, string name, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Croak!");
    }
}