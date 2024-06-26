namespace Assignment2;

public class SeparateURL
{
    public void URL()
    {
       
        Console.WriteLine("Enter a URL:");
        string input = Console.ReadLine().Trim();
        
        string protocol = "";
        string server = "";
        string resource = "";

       
        int protocolIndex = input.IndexOf("://");
        if (protocolIndex != -1)
        {
            protocol = input.Substring(0, protocolIndex);
            input = input.Substring(protocolIndex + 3);
        }

        int resourceIndex = input.IndexOf('/');
        if (resourceIndex != -1)
        {
            server = input.Substring(0, resourceIndex);
            resource = input.Substring(resourceIndex + 1);
        }
        else
        {
            server = input;
        }
        
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}