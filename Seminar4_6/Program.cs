Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

{
    int result = Convert.ToInt32(Math.Pow(numberA, numberB));

    Console.WriteLine($"{numberA} ^ {numberB} = {result}");
}
Console.ReadLine();

