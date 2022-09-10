/* Написать программу, которая из имеющегося массива 
строк формирует массив из строк, длина которых меньше либо равна 3 символа.*/

Console.Write("Enter the length of array = ");
int length = int.Parse(Console.ReadLine());
string[] array = new string[length];
string[] newArray = new string[array.Length];
Console.WriteLine("Enter the elements of array: ");
FillArray(array);
PrintArray(array);
int lenthNewArray = FillNewArray(array, newArray);
if (lenthNewArray == 0)
{
    Console.WriteLine("No elements less than 3");
}
else
{
    PrintArray(newArray);
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

int FillNewArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
        newArray[j] = array[i];
        j++;
        }
    }
    return j;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}