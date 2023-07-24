// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элементы(через пробел), пожалуйста не вводите больше элементов чем указали выше: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int GetSummNumber(int[] array)
{
int summ=0;
for (int i=0; i < size; i++)
{
if (array[i]>0)
{
summ++;
}
}
return summ;
}
Console.Write($"в массиве[{String.Join(",", array)}]");
Console.WriteLine($"чисел больше 0: {GetSummNumber(array)}");