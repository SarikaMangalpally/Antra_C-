namespace Assignment2;

public class LongestSequence
{
    public void sequence()
    {
        
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int maxLength = 0;
        int maxStartIndex = 0;
        int currentLength = 1;
        int currentStartIndex = 0;

       
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;

                
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                }
            }
            else
            {
                currentLength = 1;
                currentStartIndex = i;
            }
        }
        
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStartIndex = currentStartIndex;
        }
        
        Console.WriteLine("Longest sequence of equal elements:");
        for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
