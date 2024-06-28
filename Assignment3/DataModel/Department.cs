namespace Assignment3;

public class Department
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public Instructor Head { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}
