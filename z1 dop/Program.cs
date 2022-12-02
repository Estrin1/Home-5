// Задача 1. Задан массив из случайных цифр на 15 элементов.
// На вход подаётся трёхзначное натуральное число. Напишите 
//программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
//{0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
//{4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет


void DOP1()
{
    
    int size = 5;
    int[] array = new int[size];
    Console.WriteLine("Введите 3х значное число");
    int x = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    Fill(array, 1, 3);
    print(array);

    for (int i = 0; i < size -2 ; i++)
    {
        if (array[i]== x/100 && array[i+1]==x/10 - x/100 *10 && array[i+2]== x % 10 ) flag = true;
    }

    Console.WriteLine();

    if (flag) Console.WriteLine($"Последовательность есть");
    else Console.WriteLine($"Последовательности нет");
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
DOP1();