// ========================================================================
// №39 Напишите программу, которая перевернёт одномерный массив (последний 
// элемент будет на первом месте, а первый - на последнем и т.д.)
// Например: [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)менять числа местами 
// в исходном массиве; 2) создать новый массив и в него записать 
// перевёрнутый исходный массив по элементам.
// ========================================================================

//создаётся рандомный массив с заданными пользователем границами
int[] FillArray(int length, int arrMin, int arrMax)
{
    //генератор случайных чисел
    Random rnd = new Random();
    //создаём массив
    int[] array = new int[length];
    if (arrMin < arrMax)
    {
        //заполняем массив
        for (int i = 0; i < length - 1; i++)
        {
            array[i] = rnd.Next(arrMin, arrMax + 1); //+1 чтобы введённая пользователем верхняя граница входила в расчёт
        }
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

//метод разворота массива и создание нового
int[] SwapNewArray(int[] array)
{
    int[] outArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[array.Length - 1 - i];
    }
    return outArray;
}

//метод разворота массива и создание нового
int[] SwapArray(int[] array)
{
    int buffElement = 0;
    for (int i = 0; i < array.Length / 2; i++) //до половины, так как больше не надо
    {
        buffElement = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = buffElement;
    }
    return array;
}

int[] arr = FillArray(9,1,100);
Console.WriteLine("Исходный массив: ");
Print1DArray(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый перевёрнутый массив: ");
Print1DArray(copyArr);
Console.WriteLine("Исходный массив: ");
Print1DArray(arr);

arr = SwapArray(arr);
Console.WriteLine("Перевёрнутый исходный массив: ");
Print1DArray(arr);
