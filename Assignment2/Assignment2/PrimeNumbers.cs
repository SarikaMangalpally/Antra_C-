namespace Assignment2;
public class PrimeNumbers(int startNumber, int endNumber)
{
    int startNum = startNumber;
    int endNum = endNumber;
    public void Primes()
    {
        int[] primes = FindPrimesInRange(startNum, endNum);
        
        Console.WriteLine($"Prime numbers between {startNum} and {endNum}:");
        foreach (int prime in primes)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        return primes.ToArray();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}