// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Zadacha34()
{
    Random rand = new Random();
    int size = rand.Next(5, 10);
    int[] array = new int[size];
    int count = 0;
    Fill(array, 100, 999);
    print(array);

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество четных чисел в массиве >  {count}");
}

void Fill(int[] massive, int min, int max)
{
    Random rand = new Random();
    int size = massive.Length;
    for (int i = 0; i < size; i++) massive[i] = rand.Next(min, max);
}

void print(int[] massive)
{
    for (int i = 0; i < massive.Length; i++) Console.Write($"  {massive[i]}");
}
Zadacha34();