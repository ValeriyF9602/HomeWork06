/*****************************************************

Задача 41.
Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*****************************************************/


int[] InputArray(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

void GreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    System.Console.WriteLine($"Количество чисел больше нуля: {count}");
}

var myArray = InputArray("Введите числа через пробел");
GreaterThanZero(myArray);