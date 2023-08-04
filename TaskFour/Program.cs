Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

EvenNumbers(number);

void EvenNumbers(int number){
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i} ");
        }
    }
}

