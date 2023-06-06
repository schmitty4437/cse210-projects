using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        // Ask for user grade percentage
        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        float percent = float.Parse(gradePercentage);
        string grade = "";
        string sign = "";
        string passFail = "";

        float remainder = percent % 10;

        // Check to see what the grade letter is
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80 && percent < 90)
        {
            grade = "B";
        }
        else if (percent >= 70 && percent < 80)
        {
            grade = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // Check to see if the remainder will give them a plus or minus on the grade
        if (remainder >= 7 && grade != "A" && grade != "F")
        {
            sign = "+";
        }
        else if (remainder < 3 && grade != "F")
        {
            sign = "-";
        }

        //Check to see if they passed
        if (percent >= 70)
        {
            passFail = "Passed";
        }
        else
        {
            passFail = "Failed";
        }

        //Print message to user
        Console.WriteLine($"Your grade is {grade}{sign}. You {passFail}.");
    }
}