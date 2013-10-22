using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order. 
//Merge the lists and sort them by first name and last name.

class AbstractClass
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student("Ivan", "Nikolov", 9),
            new Student("Pavel", "Todorov", 8),
            new Student("Dimitur", "Vasilev", 12),
            new Student("Nikolay", "Georgiev", 11),
            new Student("Atanas", "Dimitrov", 7),
            new Student("Evgeni", "Onegin", 10),
            new Student("Petur", "Veselinov", 4),
            new Student("Angel", "Kolev", 6),
            new Student("Stefan", "Hristov", 5),
            new Student("Lazar", "Ivanov", 1)
        };

        var sortedStudents =
            from student in students
            orderby student.Grade ascending
            select student;

        foreach (var student in sortedStudents)
        {
            Console.WriteLine("Student: {0} {1}, Grade: {2}", student.FirstName, student.LastName, student.Grade);
        }

        List<Worker> workers = new List<Worker>()
        {
            new Worker( "Asen","Petrov", 250, 8 ),
            new Worker( "Petur","Todorov", 350, 8 ),
            new Worker( "Todor","Evlogiev", 50, 8 ),
            new Worker( "Vasil","Hristov", 1500, 8 ),
            new Worker( "Valentin","Ivanov", 800, 8 ),
            new Worker( "Milen","Ginev", 210, 8 ),
            new Worker( "Stanislav","Mitrev", 30, 8 ),
            new Worker( "Stanimir","Peshev", 145, 8 ),
            new Worker( "Miroslav","Georgiev", 731, 8 ),
            new Worker( "Kiril","Slavov", 235, 8 )
        };

        var sortedWorkers =
            from worker in workers
            orderby worker.MoneyPerHour()
            select worker;

        Console.WriteLine();
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine("Worker: {0} {1}, \nMoney Per Hour: {2}", worker.FirstName, worker.LastName,
                worker.MoneyPerHour());
        }
        Console.WriteLine();

        List<Human> people = students.Concat<Human>(workers).ToList();

        people = people.OrderBy(person => person.FirstName).ThenBy(person => person.LastName).ToList();

        foreach (var person in people)
        {
            Console.WriteLine("Person: {0} {1} \nOccupation: {2}", person.FirstName, person.LastName,
                person.GetType());
            Console.WriteLine();
        }
    }
}