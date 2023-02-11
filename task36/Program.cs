// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
System.Console.Write("задайте длинну массива\t");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99);
    System.Console.WriteLine($" {i} = {array[i]}");
}
int sum = 0;
for (int j = 1; j < array.Length; j += 2)
{
    sum = sum + array[j];
}
System.Console.WriteLine($"сумма нечетных индексов массива равна {sum}");