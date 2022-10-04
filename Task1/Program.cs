// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
using static System.Console;
Clear();

Write("Введите M чисел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write($"{String.Join(",", array)}");
Score(array);

void Score(string[] s)
{
    int count = 0;
    foreach (string item in s)
    {
       if(int.Parse(item) > 0) count++;  
    }
    Write($" --> {count}");
}
