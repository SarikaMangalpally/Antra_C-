namespace Assignment1;

public class Greeting
{
    public void Wish()
    {
        DateTime currentTime = DateTime.Now;
        int currentHour = currentTime.Hour;
        // Console.WriteLine(currentHour);
        if (currentHour >= 5 && currentHour <= 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (currentHour >12 && currentHour <= 17)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (currentHour > 17 && currentHour <= 21)
        {
            Console.WriteLine("Good Evening");
        }
        else if (currentHour > 21 || currentHour < 5)
        {
            Console.WriteLine("Good Night");
        }
    }
    
}