namespace Assignment2;

public class ReverseString
{
    public void reverse()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        Console.WriteLine("Reversed string:");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine(); 
    }
}