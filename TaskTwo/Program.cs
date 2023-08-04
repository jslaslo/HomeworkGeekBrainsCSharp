Console.Write("Введите первое число: ");
int firstValue = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondValue = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdValue = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Max = {Max(firstValue, secondValue, thirdValue)}");

int Max(int firstValue, int secondValue, int thirdValue){
    if(firstValue > secondValue && secondValue>thirdValue){
        int max = firstValue;
        return max;
    }
    else if (secondValue > firstValue && firstValue > thirdValue){
        int max = secondValue;
        return max;
    }
    else{
        return thirdValue;
    }
}