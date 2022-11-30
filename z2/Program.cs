// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
//[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

void Zadacha36()
{
    Random rand = new Random();
    int size = rand.Next(5,10);
    int[] array = new int[size];
    int count = 0;
    Fill(array, -10, 10);
    print(array);
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0&& i !=0) count = count + array[i];
    }
    Console.WriteLine();
    
   Console.WriteLine($"сумма чисел с четным индексом >  {count}");
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
Zadacha36();