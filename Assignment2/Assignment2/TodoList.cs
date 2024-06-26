namespace Assignment2;

public class TodoList
{
    List<string> Todo = new List<string>();
    public void action()
    {
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine().Trim();
    
            if (input.StartsWith("+"))
            {
                string item = input.Substring(1).Trim();
                Todo.Add(item);
            }
            else if (input.StartsWith("--"))
            {
                Todo.Clear();
            }
            else if (input.StartsWith("-"))
            {
                string item = input.Substring(1).Trim();
                Todo.Remove(item);
            }
            else
            {
                Console.WriteLine("Invalid command. Please use '+ item', '- item', or '--' to clear.");
            }
    
    
            Console.WriteLine("\nCurrent list:");
            foreach (string item in Todo)
            {
                Console.WriteLine("- " + item);
            }
    
            Console.WriteLine();
         }
    }
}