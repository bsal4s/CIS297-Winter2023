using System.Linq;
using Week7_Linq;





// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> numbers = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

IEnumerable<int> evenResult = new List<int>();

foreach( int value in numbers)
{
    if (value % 2 == 0)
    {
        evenResult.Append(value);
    }
}

IEnumerable<int> linqEvenResult = from value in numbers
                                  where value % 2 == 0
                                  select value;

IEnumerable<int> linqMethodEvenResults =
    numbers.Where(value => value % 2 == 0)
    .Select(value => value);
    

foreach( int value in linqMethodEvenResults)
{
    Console.WriteLine(value);
}

Student eric = new("Eric", 100);
Student jeb = new Student("Jeb", 25);
Student bob = new Student { Name = "Bob", Score = 75 };
Student vivi = new Student("Vivi", 75);
Student jasmine = new Student("Jasmine", 100);

List<Student> classList = new List<Student> { eric, jeb, bob, vivi, jasmine };

var passingStudents =
    classList.Where(student => student.Score >= 67).
    Select(student => $"{student.Name} {student.Score}");
    
foreach( string student in passingStudents)
{
    Console.WriteLine(student);
}


var hasMultipleStudentsWithSameScore = classList.GroupBy
    (student => student.Score).Any(group => group.Count() > 1);

List<KeyValuePair<double, List<Student>>> groups = new List<KeyValuePair<double, List<Student>>>();

foreach( var student in classList)
{
    double score = student.Score;
    bool newGroup = true;
    foreach(var group in groups)
    {
        if ( group.Key == score)
        {
            group.Value.Add(student);
            newGroup = false;
        }
    }
    if (newGroup)
    {
        groups.Add(new KeyValuePair<
            double, List<Student>>(score, new List<Student> { student }));
    }
}

var studentsWithHighestScore = classList.
    Where(student => student.Score == 
        classList.Max(student => student.Score));

foreach( var student in studentsWithHighestScore)
{
    Console.WriteLine(student);
}