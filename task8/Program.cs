// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

int maxNumber = numbers[0];
int maxIndex = 0;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
        maxIndex = i;
    }
}

Console.WriteLine($"Array'deki en boyük sayı: {maxNumber}");
Console.WriteLine($"En boyük sayının ilk indeksi: {maxIndex}");