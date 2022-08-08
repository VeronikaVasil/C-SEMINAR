// Write prog 2 //Ввести два числа и проверить является ли второе число кратным первому

Console.WriteLine("Input number1: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number2: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int remain = (number1 % number2);

if (remain == 0)
{
    Console.WriteLine ("кратно");
}
else
{
    Console.WriteLine ("некратно"+ number1 % number2);
}
