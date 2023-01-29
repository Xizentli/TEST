/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/


//печатаем массив
void PrintArray(string [] arrayStr)
{
    for (int i = 0; i < arrayStr.Length; i++)
    {
        Console.Write($"{arrayStr[i]} ");
    }
    Console.WriteLine();
}

//создание нового массива
string [] NewArray(string[] arrayStr)
{
    string [] newArr = new string [arrayStr.Length]; //создаем новый массив, равный длине массива, принятого методом на вход
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if(arrayStr[i].Length <= 3)
        {
            newArr[i] = arrayStr[i];
        }
    }
    return newArr;
}

string [] arrayStr = {"hello", "2", "world", ":-)"}; //инициализируем массив
Console.WriteLine("Первоначальный массив: ");
PrintArray(arrayStr); //печатаем первоначальный массив

string [] arrayStrNew = NewArray(arrayStr);//инициализируем новый массив
Console.WriteLine("Получившийся массив: ");
PrintArray(arrayStrNew); //печатаем новый массив