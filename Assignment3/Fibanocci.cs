namespace Assignment3;

public class Fibanocci
{
    public int series(int number)
    {
        int first = 0;
        int second = 1;
        int finalCount = 0;
        
        if (number == 0)
        {
            return 0;
        }
        else if (number == 1 || number == 2)
        {
            return 1;
        }
        else
        {
            for (int i = 1; i < number; i++)
            {
                finalCount = first + second;
                first = second;
                second = finalCount;
            }
        }
        return finalCount;
    }
}