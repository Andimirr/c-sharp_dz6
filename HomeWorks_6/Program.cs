Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию
(не используем Enter). Числа разделены пробелами.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0 7 8 -2 -2 -> 2
1 -7 567 89 223-> 4


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов большу нуля-> {count}");

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1, b1, k2, b2);
