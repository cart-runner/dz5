//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
System.Console.WriteLine("задайте количество элементов");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 999);
    System.Console.WriteLine(array[i]);
}
int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"количество четный чисел в массиве {count}");
