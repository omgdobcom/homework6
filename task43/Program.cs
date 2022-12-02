// Задача 43:  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите  значение точки b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  значение точки k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  значение точки b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  значение точки k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k1 - k2);
    return x;
} 

double FindY(double b1, double k1)
{
    double x = FindX(b1,k1,b2,k2);
    double y = k1 * x + b1;
    return x;
}

double x = FindX(b1, k1, b2, k2);
double y = FindY(b1, k1);

Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");