namespace Assignment3;

public class Instructor: Person
{
    public string EmployeeId { get; set; }
    public DateTime JoinDate { get; set; }
    public Department Department { get; set; }

    public override decimal CalculateSalary()
    {
        // Example salary calculation for an instructor, with bonus for experience
        int experienceYears = CalculateExperience();
        return Salary + (500 * experienceYears);
    }

    public int CalculateExperience()
    {
        int experience = DateTime.Now.Year - JoinDate.Year;
        if (DateTime.Now.DayOfYear < JoinDate.DayOfYear)
        {
            experience--;
        }
        return experience;
    }
}
