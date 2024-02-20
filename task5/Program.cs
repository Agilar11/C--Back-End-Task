// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr1 = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
int[] arr2 = { 5, 6, 9, 4, 3, 2, 1 };

var commonElements = arr1.Intersect(arr2).ToArray();

Console.WriteLine("Common elements between the arrays:");
foreach (var element in commonElements)
{
    Console.Write(element + " ");
}