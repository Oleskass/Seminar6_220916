// ========================================================================
// #42 Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное. Например: 45 -> 101101; 3 -> 11; 2 -> 10
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

// string BinConvert(int A)
// {
//     string res = String.Empty; //или = "";
//     while (A > 0)
//     {
//         res = A % 2 + res;
//         A /= 2; // A=A/2
//     }
//     return res;
// }


int inputNumber = ReadData("Введите число: ");

// PrintResult("Исходное число в бинарном формате: ", BinConvert(inputNumber));
// //PrintResult($"Число {inputNumber} в двоичном представлении: {BinConvert(inputNumber)}");

string numbBin = Convert.ToString(inputNumber, 2);
Console.WriteLine($"Число {inputNumber} в двоичной системе: {numbBin}");

numbBin = Convert.ToString(inputNumber, 8);
Console.WriteLine($"Число {inputNumber} в восьмеричная системе: {numbBin}");

numbBin = Convert.ToString(inputNumber, 16);

Console.WriteLine($"Число {inputNumber} в шестнадцатеричная системе: {numbBin}");