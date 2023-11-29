using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine();

// Step 3: Create the base class
// 5. Test your class by returning to the Main method in the Program.cs file. Create 
// a simple assignment, call the method to get the summary, and then display it to the screen.
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");    
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(); 

// Step 4: Create the MathAssignment class
// 6. Test your class by returning to the Main method and creating a new MathAssignment object and set 
// its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

// Step 5: Create the WritingAssignment class
// 6. Return to Main and test your new class.
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(assignment3.Get)        




    }
}