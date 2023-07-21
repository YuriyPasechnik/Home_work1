// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int numberA, int minValue, int maxValue)
{
int array = new int[numberA];
Random random = new Random();
for (int i=0; i < numberA; i++)
{
array[i] = random.Next(minValue,maxValue+1);
}
return array;
}
void PrintArray(int[] array)
{
Console.WriteLine($"[");
for (int i=0; i < array.Lenght -1; i++)
{
Console.WriteLine($"{array[i]}, ");
}
Console.WriteLine($"]");
}
int GetInput(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите длину массива: ");
int min = GetInput("Введите начальное значение массива для диапозона случайного числа: ");
int max= GetInput("Введите конечное значение массива для диапозона случайного числа: ");
Console.WriteLine($"Массив: {PrintArray(array)}");