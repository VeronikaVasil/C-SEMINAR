// Получить первую и третью цифру трехзначного числа

int number = Convert.ToInt32(Console.ReadLine());
int result = (number / 100) * 10 + number % 10;
Console.WriteLine($"Первая и третья цифра числа равна {result}");
