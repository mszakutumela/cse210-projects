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
    
// Step 4: Create the MathAssignment class
1. Create a new file for the MathAssignment class.
2. Create this class and make sure to specify that it inherits from the base Assignment class.
3. Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
Add the GetHomeworkList() method.
Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.

}