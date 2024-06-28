namespace Assignment3;

public class Course
{
    public string Name { get; set; }
    public char Grade { get; set; }

    public double GetGradePoints()
    {
        switch (Grade)
        {
            case 'A': return 4.0;
            case 'B': return 3.0;
            case 'C': return 2.0;
            case 'D': return 1.0;
            case 'F': return 0.0;
            default: return 0.0;
        }
    }
}
