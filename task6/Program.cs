// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    // Given array of numbers
    int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

    // Your name
    string name = "Murad";

    // Check the count of each letter in the name
    bool nameExists = true;
    foreach (char letter in name)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if ((int)letter == num)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"{letter} appears {count} times.");
        }
        else
        {
            Console.WriteLine($"{letter} does not appear in the array.");
            nameExists = false;
        }
    }

    if (nameExists)
    {
        Console.WriteLine($"{name} is present in the array.");
    }
    else
    {
        Console.WriteLine($"{name} is not present in the array.");
    }