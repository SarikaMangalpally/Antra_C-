namespace Assignment3;

public abstract class Person
{
    private List<string> addresses = new List<string>();
    private decimal salary;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            salary = value;
        }
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public IEnumerable<string> GetAddresses()
    {
        return addresses;
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
        {
            age--;
        }
        return age;
    }

    public abstract decimal CalculateSalary();
}

