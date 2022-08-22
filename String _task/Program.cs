// Подсчёт символов во введённой строке
string number = Console.ReadLine();
int size = number.Length;
if (number.Length < 3)
 {
    Console.WriteLine("Наша строчка не имеет 3 символа");
 }
 Console.Write($"Символов в строке {size}");
 