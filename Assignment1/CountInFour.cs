namespace Assignment1;

public class CountInFour
{
    public void incrementbyFour()
    {
        for (int increment = 1; increment <= 4; increment++)
        {
            for(int i =0; i<=24; i += increment)
            {
                Console.Write(i);
                if (i + increment <= 24)
                {
                    
                    Console.Write(',');
                }
            }
            Console.WriteLine();
        }
    }
}