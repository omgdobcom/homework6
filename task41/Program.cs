// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int PositiveNum(int[] arr)
{
int count = 0;
 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество чисел больше нуля {PositiveNum(arr)}");