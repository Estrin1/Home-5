// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//3,21 7,04 22,93 -2,71 78,24] -> 80,95

void Zadacha38()
{
    Random rand = new Random();
    int size = rand.Next(5,10);
    int[] array = new int[size];
    int min = array[0]; int max =array[0];
    Fill(array, -10, 10);
    print(array);
    for (int i = 0; i < size; i++)
    {
        if (array[i]< min) min = array[i];
        if (array[i]> max) max = array[i];
    }
    Console.WriteLine();
    
   Console.WriteLine($"разница между элементами  {max} - ({min}) = {max - min}");
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
Zadacha38();
