// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

    int sum = 0; 
foreach (int i in arr)
{
    sum += i;
}
Console.WriteLine(sum);