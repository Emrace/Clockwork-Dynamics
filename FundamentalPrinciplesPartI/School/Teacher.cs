using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Teacher : Person
{
    public List<Discipline> Disciplines { get; set; }

    public Teacher(string name, List<Discipline> disciplines)
        : base(name)
    {
        this.Disciplines = disciplines;
    }
}