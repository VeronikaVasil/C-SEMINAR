//26

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers(int number)
{
    int count = 0; // счетчик
    while (number > 0)
    {
        count++;//count = count + 1
        number /= 10; // Деление на 10
    }
    return count;
}

Console.WriteLine($"Количество чисел: {GetCountNumbers(num)}");
