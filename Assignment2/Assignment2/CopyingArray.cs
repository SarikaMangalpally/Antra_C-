namespace Assignment2;

public class CopyingArray
{
    public void copy()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i+1;
        }

        int[] secondArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            secondArr[i] = arr[i];
        }
        Console.WriteLine("Original Array");
        foreach (int item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Console.WriteLine("Copied Items");
        foreach (int item in secondArr)
        {
            Console.Write($"{item} ");
        }
    }
}