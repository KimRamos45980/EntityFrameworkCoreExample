using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Someone's Name",
    EmailAddress = "Someone.Hello@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new()
{
    FullName = "Person's Name",
    EmailAddress = "Person.email@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add(s); // Prepares the Student Insert statement
dbContext.SaveChanges(); // Excutes pending insert. (In Actuality: Excutes any pending insert/update/delete)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method Syntax
// allStudents = (from stu in dbContext.Students
//              select stu).ToList();                    // Query Syntax

foreach (Student student in allStudents)
{
    Console.WriteLine($"{student.FullName} has an email of {student.EmailAddress}");
    Console.WriteLine();
}