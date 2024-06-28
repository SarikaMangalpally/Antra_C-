namespace Assignment3.Repository;

public interface IPerson
{
    int CalculateAge(Person person);
    decimal CalculateSalary(Person person);
    void AddAddress(Person person, string address);
    IEnumerable<string> GetAddresses(Person person);
    
}