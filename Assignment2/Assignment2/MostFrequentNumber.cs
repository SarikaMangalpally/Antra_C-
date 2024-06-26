namespace Assignment2;

public class MostFrequentNumber
{
    public void FrequentValue()
    {
        Console.WriteLine("Enter the sequence of numbers (space-separated):");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        Dictionary<int, int> leftmostIndex = new Dictionary<int, int>();

        
        int maxFrequency = 0;
        int mostFrequentNumber = 0;

       
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];

            
            if (!frequency.ContainsKey(num))
            {
                frequency[num] = 0;
                leftmostIndex[num] = i; // Initialize leftmost index
            }
            frequency[num]++;

            if (frequency[num] > maxFrequency ||
                (frequency[num] == maxFrequency && leftmostIndex[num] < leftmostIndex[mostFrequentNumber]))
            {
                maxFrequency = frequency[num];
                mostFrequentNumber = num;
            }
        }

        Console.WriteLine($"The number {mostFrequentNumber} is the most frequent " +
                          $"(occurs {maxFrequency} times)");
    }
}
