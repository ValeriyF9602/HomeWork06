/***************************************************************************

Задача 43.
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

***************************************************************************/


double InputDouble(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые лежат друг на друге");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"({Math.Round(x, 1)}; {Math.Round(y, 1)})");
    }

}

double b1, k1, b2, k2;
b1 = InputDouble("Введите b1: ");
k1 = InputDouble("Введите k1: ");
b2 = InputDouble("Введите b2: ");
k2 = InputDouble("Введите k2: ");

IntersectionPoint(b1, k1, b2, k2);