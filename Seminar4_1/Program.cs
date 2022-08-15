// Методы
// Метод -  подпрограмма, которая выполняет рутинный код
// Заполнить 50 массивов: если есть метод, 
//он вызывается 50 раз
// 50 циклов for

// type NameMethod (params)
//int Calcalute (int a, int b)

int A = Convert.ToInt32(Console.ReadLine()); 

int GetSumNumbers(int number)
{
    //while
    int sum = 0; //result
    int start = 1;  //начало нашего цикла
    while (start <= number) //[1;A]
    {
        sum += start;
        start++;        //start = start + 1

    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");



