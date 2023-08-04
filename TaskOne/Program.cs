Console.Write("Введите первое число: ");
int firstValue = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondValue = int.Parse(Console.ReadLine());

Console.WriteLine($"Max = {MaxValue(firstValue, secondValue)}");

int MaxValue(int firstValue, int secondValue)
{

    if (firstValue > secondValue)
    {
        int max = firstValue;
        return max;
    }
    else
    {
        int max = secondValue;
        return max;
    }
}
