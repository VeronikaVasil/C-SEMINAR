// Напишите программу, которая принимает число N и выдает 
// произведение чисел от 1 до N

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= N; i++)
{
  factorial = factorial * i;
}
Console.WriteLine($"факториал = {factorial}");


