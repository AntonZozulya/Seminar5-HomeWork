//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 == 0)
      
      count ++;
    }
    return count;
    
    
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(CountNumbers(array));