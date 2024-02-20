int[] numbers = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
int a = 0;
int x = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 3 == 2)
    {
        a = numbers[i];
        x = i;
        break;
    }
}
Console.WriteLine(x);
