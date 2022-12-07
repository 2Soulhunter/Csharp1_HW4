/*                          Домашнее задание к семинару 4 С#
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16          */

try // Пытаемся выполнить ВЕСЬ программный код
    // Сюда засовываем всю основную программу, ну кроме функций разумеется.
{
    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ApowerB(A,B));
}
catch // если же не получилось выполнить всю программу, то уходим в этот блок и информуруем пользователя
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число цифрами!");
}

int ApowerB(int A, int B)
{
    int result = 1;
    for (int i=1; i <= B; i++) result *=A;
    return result;
}