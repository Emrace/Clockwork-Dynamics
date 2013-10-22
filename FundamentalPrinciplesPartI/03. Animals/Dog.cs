using System;

class Dog : Animal
{
    public Dog(int age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bau!");
    }
}