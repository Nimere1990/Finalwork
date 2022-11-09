/*
Написать программу, которая из имеющегося массива строк формирует массив строк,
длина которых меньше? либо равна 3 символа.
*/

void PrintArray(string[] array) // метод, который выводит одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(" , ");
    }
    Console.Write("]");
    Console.WriteLine();
}


string[] ThreeSymbol(string[] array) // метод, который создает новый массив, заполненый элементами длина которых не превышает 3 символа
{
    string text2 = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4 && array[i].Length > 0)
        {
            text2 += array[i] + " ";
        }
    }
    text2 = text2.Trim();
    string[] array2 = text2.Split();
    return array2;
}

Console.WriteLine("Введите текст, который будет преобразован в массив. Каждое слово будет элементом массива:");
string text = Convert.ToString(Console.ReadLine()) + "";                      // защита, на случай если пользователь ничего не введет, просто нажмет enter
string[] arr = text.Split();
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
string[] arr2 = ThreeSymbol(arr);
Console.WriteLine("Массив, состоящий из элементов исходного массива, длина которых не превышает 3 символа: ");
PrintArray(arr2);