// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива массива:  ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива массива:  ");
int finish = Convert.ToInt32(Console.ReadLine());
double GetDifferenceNumber(double[] array)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    double Difference = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    //Console.WriteLine($"max:{max} min:{min}");
    Difference = max - min;
    return Difference;
}
double[] GenerateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = random.NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

double[] array = GenerateRandomArray(size, start, finish);
Console.WriteLine($"в массиве[{String.Join(",", array)}]");
Console.WriteLine(
    $"разница между максимальным и минимальным элементом {GetDifferenceNumber(array)}"
);
