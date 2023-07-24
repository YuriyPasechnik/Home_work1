// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int GetEvenNumber(int[] array)
{
int summ=0;
for (int i=0; i < size; i++)
{
if (array[i]%2==0)
{
summ = summ + 1;
}
}
return summ;
}
int[]GenerateRandomArray (int start, int finish)
{
int[]array = new int[size];
for (int i=0; i < size; i++)
{
array[i] = new Random().Next(start, finish+1);
}
return array;
}
int[] array = GenerateRandomArray(0, 999);
Console.Write($"в массиве[{String.Join(",", array)}]");
Console.WriteLine($"количество четных чисел равно {GetEvenNumber(array)}");