// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

int[] firstThreeElements = new int[3];
Array.Copy(numbers, firstThreeElements, 3);

int remainder = firstThreeElements[2] % 2;

int remainderIndex = Array.IndexOf(numbers, remainder);

Console.WriteLine($"First three elements: [{string.Join(", ", firstThreeElements)}]");
Console.WriteLine($"Remainder when the third element is divided by 2: {remainder}");
Console.WriteLine($"Index of the remainder: {remainderIndex}");