using System;
using System.Text.RegularExpressions;

namespace Assignment2;

public class ReverseSentence
{
    public void reverse()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        
        string separatorsPattern = @"[\.,:;=\(\)&\[\]""'\\\/\!\? ]+";
        
        string[] parts = Regex.Split(input, separatorsPattern);

        Array.Reverse(parts);

        
        int separatorIndex = 0;
        string reversedSentence = Regex.Replace(input, separatorsPattern, match =>
        {
            string separator = match.Value;
            string part = parts[separatorIndex++];
            return part + separator;
        });
        
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversedSentence);
    }
}