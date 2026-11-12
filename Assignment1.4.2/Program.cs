// Assignment 1.4.2
// Write a class: “Student” with private Backing Field:
// StudentId ( int), StudentFirstName (string), StudentLastName (string ), StudentGrade ( char ).
// Add a public property for each Backing Field.
// Instantiate the class and assign data to properties.
// Display the data on the console. 

class Student
{
    // Private backing fields
    private int studentId;
    private string studentFirstName;
    private string studentLastName;
    private char studentGrade;

    // Public properties
    public int StudentId
    { get; set; }
    public string StudentFirstName
    { get; set; }
    public string StudentLastName
    { get; set; }
    public char StudentGrade
    { get; set; }
}
class Program
{
    static void Main()
    {
        // Instantiate the Student class
        Student student = new Student();

        // Assign data to properties
        student.StudentId = 123;
        student.StudentFirstName = "Calvin";
        student.StudentLastName = "Manyvanh";
        student.StudentGrade = 'C';

        // Display the data on the console
        Console.WriteLine("Student ID: " + student.StudentId);
        Console.WriteLine("Student First Name: " + student.StudentFirstName);
        Console.WriteLine("Student Last Name: " + student.StudentLastName);
        Console.WriteLine("Student Grade: " + student.StudentGrade);
    }
}


