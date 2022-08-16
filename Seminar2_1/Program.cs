// The program outputs a random number from the segment and show max
// [10,99]

int number = new Random().Next(10,100);
//[10;99]указать 100 вместо 99
Console.WriteLine($"Random: {number}"); //Интерполяция
// camelCase
int firstDigit = number / 10;
int secondDigit = number % 10;

int maximum = firstDigit; // Пусть max - первое число (количество десятков) 
if (maximum < secondDigit) maximum = secondDigit;

Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");
