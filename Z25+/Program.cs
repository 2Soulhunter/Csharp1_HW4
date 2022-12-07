/*                          Домашнее задание к семинару 4 С#
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16          */

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
ToDegree(A, B);

int ReadInt(string message)     // Функция для ввода и конвертирования чисел
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ToDegree(int a, int b)    // Функция возведения в степень
{
    int result = 1;
    for (int i = 1; i <= b; i++) result = result * a;
    Console.WriteLine($"{A} в степени {B} = {result}");
}