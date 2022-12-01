// Задача 2. На вход подаются два числа случайной длины. 
// Найдите произведение каждого разряда первого числа на каждый 
// разряд второго. Ответ запишите в массив.
// 24, 132 -> {2, 6, 4, 4, 12, 8}

void DOP2()
{
    Console.WriteLine("Введите первое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе  число");
    int y = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[FindCount(x) * FindCount(y)];
    int c =0;
    int size1 = FindCount(x);
    int size = FindCount(y);
    for (int i = 0; i < size1; i++)
    {
       for (int j = 0; j < size; j++)
        {
          array[c]= (x % 10) * (y % 10);
          y= y/10;
          c++;
        }
         x = x/10;
        Console.WriteLine(x);
    }
    print(array);
}



//Описание методов

int FindCount(int num1)
{
int count=0; 

    while (num1 != 0)
    {
        num1 = num1 / 10;
        count++;
    }
   return count; 
}
void print(int[] massive)
{
    for (int i = 0; i < massive.Length; i++) Console.Write($"  {massive[i]}");
}

DOP2();