﻿Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

EvenNumber(number);

void EvenNumber (int number){
    if(number % 2 == 0){
        Console.WriteLine($"Число {number} является чётным");
    }
    else{
        Console.WriteLine($"Число {number} является нечётным");
    }
}
