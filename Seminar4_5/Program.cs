// 28 Ввести N и найти факториал

int num = Convert.ToInt32(Console.ReadLine());

int GetMultiply (int number)
{
    int result = 1; // 2*0 = 2; при умножении указываем 1: любое число на 1 = число
    // Multiply[1;N]
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"Факториал от {num} = {GetMultiply(num)}");
