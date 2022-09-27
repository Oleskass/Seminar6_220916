// ========================================================================
// #45 Напишите программу, которая будет создавать копию заданного 
// одномерного массива с помощью поэлементного копирования.
// ========================================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//создаётся рандомный массив с заданными пользователем границами
int[] FillArray(int length)
{
    //генератор случайных чисел
    Random rnd = new Random();
    //создаём массив
    int[] array = new int[length];
        //заполняем массив
        for (int i = 0; i < length - 1; i++)
        {
            array[i] = rnd.Next(0, 100);
    }
    return array;
}

//печатаем одномерный массив
void Print1DArray(int[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int[] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i];
    }
    return outArr;
}

int length = ReadData("Задайте длину массива: ");
int[] array = FillArray(length);
Print1DArray(array);
Console.WriteLine("Копия массива");
Print1DArray(CopyArr(array));

Console.WriteLine("Копия массива Clone");
Print1DArray((int[])array.Clone());