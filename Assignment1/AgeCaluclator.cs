namespace Assignment1;

public class AgeCaluclator
{ 
    DateTime birthDate = new DateTime(1997, 12, 20);
    DateTime currentDate = DateTime.Now;

    public void ageCalculator()
    {
        TimeSpan age = currentDate - birthDate;
        int daysOld = age.Days;

        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversy = currentDate.AddDays(daysToNextAnniversary);
        
        Console.WriteLine($"You are {daysOld} days old.");
        Console.WriteLine($"Your next anniversary is on {nextAnniversy}");
    }
}