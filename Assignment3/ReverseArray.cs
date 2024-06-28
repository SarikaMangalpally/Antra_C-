namespace Assignment3;

public class ReverseArray
{
    public int[] generateNumbers()
    {
        Console.WriteLine("Enter array length");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize - 1; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    public void reverse(int[] numbers)
    {
        int i = 0;
        int j = numbers.Length-1;
        while (i < j)
        {
            (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
            i++;
            j--;
        }
    }

    public void printNumbers(int[] numbers)
    {
        foreach (var value in numbers)
        {
            Console.Write(value + " ");
        }
    }
}
