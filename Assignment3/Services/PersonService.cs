using Assignment3.Repository;

namespace Assignment3.Services;

public class PersonService: IPerson
{
    public int CalculateAge(Person person)
    {
        return person.CalculateAge();
    }

    public decimal CalculateSalary(Person person)
    {
        return person.CalculateSalary();
    }

    public void AddAddress(Person person, string address)
    {
        person.AddAddress(address);
    }

    public IEnumerable<string> GetAddresses(Person person)
    {
        return person.GetAddresses();
    }
}