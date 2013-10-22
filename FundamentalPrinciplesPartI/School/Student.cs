using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Person
{
    private int numberInClass;

    public Student(string name, int numberInClass) : base(name)
    {
        this.NumberInClass = numberInClass;
    }

    public int NumberInClass
    {
        get
        {
            return this.numberInClass;
        }
        set
        {
            this.numberInClass = value;
        }
    }
}