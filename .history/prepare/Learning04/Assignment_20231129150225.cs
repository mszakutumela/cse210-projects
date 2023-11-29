using System;

// Step 3: Create the base class
// 1. Begin by creating a new file and a class for your base Assignment class.
// 2. Add the attributes as private member variables.
// 3. Create a constructor for this class that receives a student name and topic 
// and sets the member variables.
// 4. Add the method for GetSummary() to return the student's name and the topic.

public class Assignment
{
    private string _studentName;
    private string _assignmentTopic;

    public Assignment(string studentName, string assignmentTopic)
    {
        _studentName = studentName;
        _assignmentTopic = assignmentTopic;

    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    
    public void SetAssignmentTopic(string assignmentTopic)
    {
        _assignmentTopic  = assignmentTopic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _assignmentTopic;
    }
    
    
}