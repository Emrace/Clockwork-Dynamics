using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StudentClass
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    

    public StudentClass(List<Student> students, List<Teacher> teachers)
    {
        this.Students = students;
        this.Teachers = teachers;
    }
}