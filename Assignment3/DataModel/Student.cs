namespace Assignment3;

public class Student : Person
{
    public string StudentId { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public override decimal CalculateSalary()
    {
        // Students typically don't have a salary
        return 0;
    }

    public double CalculateGPA()
    {
        if (Courses.Count == 0) return 0;

        double totalPoints = Courses.Sum(course => course.GetGradePoints());
        return totalPoints / Courses.Count;
    }
}
