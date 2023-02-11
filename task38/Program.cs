// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
System.Console.Write("задайте длину массива\t");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99);
    System.Console.WriteLine(array[i]);
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"максимальное число массива {max}");
System.Console.WriteLine();
System.Console.WriteLine($"минимальное число массива {min}");
System.Console.WriteLine();
System.Console.WriteLine($"разница между максимальным и минимальными элементами массива {max - min}");
