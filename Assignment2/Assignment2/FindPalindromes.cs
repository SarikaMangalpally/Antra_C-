namespace Assignment2;

public class FindPalindromes
{
public void palindrome()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();
        char[] separators = { ' ', ',', '.', '!', '?', ':', ';', '-', '_', '\"', '\'', '/', '\\', '(', ')' };

        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> palindromes = new HashSet<string>();

        Func<string, bool> IsPalindrome = (str) =>
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        };

        foreach (string word in words)
        {
            if (IsPalindrome(word) && !palindromes.Contains(word))
            {
                palindromes.Add(word);
            }
        }
        
        List<string> sortedPalindromes = palindromes.OrderBy(p => p).ToList();
        
        Console.WriteLine("Palindromes:");
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }
}
