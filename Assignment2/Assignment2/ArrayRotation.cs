namespace Assignment2;

public class ArrayRotation
{
    public void Rotate()
    {
       
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.WriteLine("Enter the value of k:");
        int k = int.Parse(Console.ReadLine());
        
        int n = array.Length;
        int[] sum = new int[n];
        
        for (int r = 1; r <= k; r++)
        {
           
            RotateRight(array);
            
            for (int i = 0; i < n; i++)
            {
                sum[i] += array[i];
            }
            Console.WriteLine($"rotated{r}[] = {string.Join(" ", array)}");
        }

        Console.WriteLine("sum[] = " + string.Join(" ", sum));
    }
    static void RotateRight(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int last = arr[arr.Length - 1];

        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[0] = last;
    }
}
