int[] testArray = {-2,-1,0,1,2};
int searchElement = Convert.ToInt32(Console.ReadLine());

string foundResult = "не найден"; // false - element not found
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] == searchElement) 
    {
        foundResult = "найден"; // element found
        break;
    }
}
Console.WriteLine($"Элемент {searchElement}: {foundResult}");
// if (foundResult == "найден") Console.WriteLine($"Элемент {searchElement} присутствует ");
//  //foundResult == true => foundResult
// else Console.WriteLine($"Элемент {searchElement} ОТСУТСТВУЕТ ");
