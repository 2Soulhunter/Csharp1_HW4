/*                          Домашнее задание к семинару 4 С#
Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
*/

try // Пытаемся выполнить ВЕСЬ программный код
    // Сюда засовываем всю основную программу, ну кроме функций разумеется.
{
    Console.WriteLine("Введите массив из 8 чисел: ");
    EnterArray();
}
catch // если же не получилось выполнить всю программу, то уходим в этот блок и информуруем пользователя
{
    Console.WriteLine("Ошибка: Надо было вводить массив цифрами!");
}

void EnterArray()
{
    int[] array = new int[8];
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Вы ввели массив: [");
    for (int i = 0; i < array.Length - 1; i++) 
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}