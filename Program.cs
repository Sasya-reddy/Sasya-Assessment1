using System;

class Program1
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];

        Console.WriteLine("Enter 9 elements for the 3x3 matrix:");

        // Reading the matrix elements
        try
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter integer values only.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return;
        }

        // Printing the matrix
        try
        {
            Console.WriteLine("The 3x3 matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while printing the matrix: {ex.Message}");
        }
    }
}