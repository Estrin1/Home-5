// Задача 1*. Дан массив массивов, состоящих из натуральных чисел
// , размер которого 5. Для каждого элемента-массива требуется найти
//  сумму его элементов и вывести массив с наибольшей суммой. 
//  Если таких массивов несколько, вывести массив с наименьшим 
//  индексом.
// https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/jagged-arrays

void star()
{

    int[][] array = new int[5][];
    array[0] = new int[5];
    array[1] = new int[5];
    array[2] = new int[5];
    array[3] = new int[5];
    array[4] = new int[5];
    Fillmassive(array, -5, 10);
    PrintMassive(array);
    FindSumm(array);
    
    
}

// Описание методов
void Fillmassive(int[][] massive, int min, int max)
{
    Random rand = new Random();
    int size = massive.Length;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            massive[i][j] = rand.Next(min, max);
    }
}

void PrintMassive(int[][] massive)
{
    int size = massive.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"   массив № {i}" + "\n");
        for (int j = 0; j < size; j++)
        {

            Console.Write($"  {massive[i][j]}");
        }
        Console.WriteLine("\n");
    }
}

void FindSumm(int[][] massive)
{
    
    int summax = 0;
    int flag = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        int summ = 0;
        for (int j = 0; j < massive.Length; j++)
        {
            summ += massive[i][j];
        }
        if (summ > summax)
        {
            summax = summ;
            flag = i;
        }

    }
    Console.WriteLine($"Индекс массива с максимальной суммой чисел > {flag}");
}
star();