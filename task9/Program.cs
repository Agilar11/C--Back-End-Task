// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

Console.WriteLine("Array'deki 4 sayısının indeksleri:");

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 4)
    {
        Console.WriteLine($"Index: {i}");
    }
}