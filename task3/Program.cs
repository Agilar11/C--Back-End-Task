// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Define an array of integers
int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

var distinctSortedArray = arr.Distinct().OrderBy(x => x).ToArray();

Console.WriteLine("Array with unique sorted elements:");
foreach (var num in distinctSortedArray)
{
    Console.Write(num + " ");
}