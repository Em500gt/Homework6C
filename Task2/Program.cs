// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static System.Console;
Clear();

Write("Введите значения (4 точки b1, k1, b2, k2): ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Straight(double.Parse(parameters[0]), double.Parse(parameters[1]), double.Parse(parameters[2]), double.Parse(parameters[3]));

void Straight(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x}; {y})");
}
