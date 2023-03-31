// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double defence(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return max - min;
}
Console.Clear();
double[] array = {3.03, 7.85, 22.13, 2.05, 78.48};
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между макс и мин элем-и массива: {defence(array)}");