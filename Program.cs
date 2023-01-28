Console.Write("введите длину массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

string[] array = new string[arrLength];
string[] resultArray = new string[arrLength];
int newLength = 0;
for (int i = 0; i < arrLength; i++)
{
    Console.Write($"введите {i}-й элемент массива: ");
    array[i] = Convert.ToString(Console.ReadLine());

    if (array[i].Length < 4)
    {
        resultArray[newLength] = array[i];
        newLength++;
    }
}
Array.Resize(ref resultArray, newLength);

var str = string.Join(" ", array);
Console.WriteLine($"Исходный массив {str}");
str = string.Join(" ", resultArray);
Console.WriteLine($"Результат {str}");