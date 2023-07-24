// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива массива:  ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива массива:  ");
int finish = Convert.ToInt32(Console.ReadLine());
int GetSummNumber(int[] array)
{
int summ=0;
for (int i=0; i < size; i++)
{
if (i%2!=0)
{
summ = summ + array[i];
}
}
return summ;
}
int[]GenerateRandomArray ()
{
int[]array = new int[size];
for (int i=0; i < size; i++)
{
array[i] = new Random().Next(start, finish+1);
}
return array;
}
int[] array = GenerateRandomArray();
Console.Write($"в массиве[{String.Join(",", array)}]");
Console.WriteLine($"сумма элеиентов стоящих на нечетных позициях {GetSummNumber(array)}");