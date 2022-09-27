// ========================================================================
// #44 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. Например: Если N = 5 -> 0 1 1 2 3;
// Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8
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

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

string Fibonacci(int num)
{
    string res = ""; //то же что и String.Empty
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first; //
        buf = first + last; //
        first = last; //
        last = buf; //
    }
    return res;
}

// //развёрнутая программа
// int numFib = ReadData("Введите количество чисел Фибоначчи: ");
// string line = Fibonacci(numFib);
// PrintResult("Числа Фибоначчи: ", line);

//программа в одну строчку
PrintResult("Числа Фибоначчи: ", Fibonacci(ReadData("Введите количество чисел Фибоначчи: ")));


// //Вариант решения с массивом - не предусматривает ввод 1
// // Метод, печатает одномерный массив
// void Print1DArray(int[] arr)
// {
//     string arrString = "";
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         arrString += arr[i] + ", ";
//     }
//     arrString += arr[arr.Length - 1];
//     Console.WriteLine(arrString);
// }

// int[] Fibonacci(int number)
// {
//     int[] fibonacciArr = new int[number];
//     fibonacciArr[0] = 0;
//     fibonacciArr[1] = 1;
//     for (int i = 2; i < number; i++)
//     {
//         fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
//     }
//     return fibonacciArr;
// }

// int inputNumber = ReadData("Введите длину последовательности: ");

// Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
// Print1DArray(Fibonacci(inputNumber));