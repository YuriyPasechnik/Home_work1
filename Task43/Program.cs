// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("дано уравнение: y = k1 * x + b1, y = k2 * x + b2   ");
Console.WriteLine("Введите b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:  ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] GetIntersection(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    Console.WriteLine($"{b1} {k1} {b2} {k2}");
    if (k1 == k2)
    {
        Console.WriteLine("Прямые пралаллельны и не пересекаются");
        return null;
    }
    else
    {
        point[0] = (b2 - b1) / (k1 - k2);
        point[1] = k1 * point[0] + b1;
        return point;
    }
}

double[] point = GetIntersection(b1, k1, b2, k2);
if (point != null)
    Console.WriteLine($"точка пересечения прямых: {String.Join(",", point)}");