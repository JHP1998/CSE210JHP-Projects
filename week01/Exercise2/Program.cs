using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);

        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        
         }
        else if (percentage >= 80)
        {
            letterGrade = "B";

        }
        else if (percentage >= 70)
        {
            letterGrade = "C";

        }
        else if (percentage >= 60)
        {
            letterGrade = "D";

        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
     
}