using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Johnny Test", "Mac n Cheeze");
        string assignmentSummary = newAssignment.GetSummary();
        Console.WriteLine(assignmentSummary);

        MathAssignment newMath = new MathAssignment("Chicken Little", "Imaginary Numbers", "8.2", "4-19");
        string mathSummary = newMath.GetSummary();
        string mathHomework = newMath.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(mathHomework);

        WritingAssignment newWriting = new WritingAssignment("George Washingtoad", "History", "How I Crossed the River");
        string writingSummary = newWriting.GetSummary();
        string writingInfo = newWriting.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    }
}