/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/


int[] GetNumberFromUser(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int GetPositiveDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(" , ");
        }
    }
}
int[] newArray = GetNumberFromUser(5, -1000, 1000);
Console.WriteLine();
PrintArray(newArray);
int number = GetPositiveDigits(newArray);
Console.WriteLine();
Console.Write($"Введено чисел больше 0: {number}");
Console.WriteLine();
