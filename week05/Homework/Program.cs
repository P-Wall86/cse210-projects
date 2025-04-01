using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();

        MathAssignment mathHomework = new MathAssignment("Noah Smith", "Algebra", "5.2", "1-10");  
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingHomework = new WritingAssignment("Oliver Cowdery", "Writing 101", "My experience with the American indians.");  
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}