using _3;

Console.WriteLine("Enter the info of a student (firstname, lastname, faculty number): ");

var inputLine = Console.ReadLine().Split(' ');

var firstName = inputLine[0];
var lastName = inputLine[1];
var facultyNumber = inputLine[2];

Student student;
try
{
    student = new Student(firstName, lastName, facultyNumber);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;
}

Console.WriteLine("Enter the info of a worker (firstname, second name, week salary, hours per day): ");

inputLine = Console.ReadLine().Split(' ');

firstName = inputLine[0];
lastName = inputLine[1];

var weekSalary = double.Parse(inputLine[2]);
var hoursPerDay = double.Parse(inputLine[3]);

Worker worker;
try
{
    worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;
}

Console.WriteLine(student);
Console.WriteLine(worker);