
// Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых 
// в три раза меньше их произведений. Подсчитайте их количество.

void Zadacha3()
{
    int count = 0;
    for (int i = 1; i <= 1000000; i++)
    { 
        if(FindMult(i)==FindSumm(i)+FindSumm(i)+FindSumm(i))
        {
            count++;
            Console.Write($"  {i}");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество чисел  " + count);
}

int FindSumm(int x)
{
    int summ = 0;
    int number = 0;
    while (x > 0)
    {
        number = x;
        summ = summ + number % 10;
        x = x / 10;
    }
    return summ;
}


int FindMult(int x)
{
    int Mult = 1;
    while (x > 0)
    {
        
        if (x % 10 != 0)
        {
            Mult *= x % 10;
            x = x / 10;
        }
        else x = x / 10;
    }
    return Mult;
}
Zadacha3();

// DOP3();

//  int minNumber = 1;
//         int maxNumber = 1000000;
//         int gns_amount = 0;
//         int amountNumbers = 0;

//         Console.WriteLine("\nКоличество "Хороших" чисел в интервале от 1 до 1 000 000");
//         for (int i = minNumber; i < maxNumber; i++)
//         {
//             amountNumbers = CalculateNumbers(i);
//             if ((i % amountNumbers) == 0)
//                 gns_amount++;
//         }
//         Console.WriteLine("составило {0:N0} штук", gns_amount);




//     static int CalculateNumbers(int i)
//     {
//         int count = 0;
//         while (i > 0)
//         {
//             i = i / 10;
//             count++;
//         }
//         return count;