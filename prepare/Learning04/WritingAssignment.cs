public class WritingAssignment : Assignment
{

    private string _title;

    // The WritingAssignment constructor has 2 variables and passes 2 of them directly
    // to the "base" constructor which is the "Assignment" constructor.
    public WritingAssignment(string studentName, string topic, string title)
         : base(studentName, topic)
    {

        // We set any variables specific to the WritingAssignment class
        _title = title;
    }       

    public string GetWritingInformation()
    {
        // We are calling the getter because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
        
    }
}

