namespace Assignment1;

public class FullPyramid
{
    int height = 5;

    public void pyramid()
    {
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2*i-1; k++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}

