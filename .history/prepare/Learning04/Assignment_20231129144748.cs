using System;

// Step 3: Create the base class
// 1. Begin by creating a new file and a class for your base Assignment class.
// 2. Add the attributes as private member variables.
// 3. Create a constructor for this class that receives a student name and topic 
// and sets the member variables.
// 4. Add the method for GetSummary() to return the student's name and the topic.
// 5. Test your class by returning to the Main method in the Program.cs file. Create 
// a simple assignment, call the method to get the summary, and then display it to the screen.

public class Assignment
{
    private string _studentName;
    private string _assignmentTopic;

    public Assignment(string _studentName, string _assignmentTopic)
    {
        _studentName = studentName;
        _assignmentTopic = _assignmentTopic;

    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    
    public void SetAssignmentTopic(string assignmentTopic)
    {
        _assignmentTopic
    }
}