// ========================================================================
// #40 Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
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
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// //вариант решения с переменной res
// bool TrglTestRes(int a, int b, int c)
// {
//     bool res = false;
//     if (a + b > c && a + c > b && b + c > a) res = true;
//     return res;
// }

//вариант решения без переменной res
bool TrglTest(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    else return false;
}

// //вариант решения в одну строку
// bool TrglTestOneline(int a, int b, int c)
// {
//     return (a + b > c) && (a + c > b) && (b + c > a); //возвращает true если выполнится условия и false если нет
// }

int a = ReadData("Введите сторону треугольника а: ");
int b = ReadData("Введите сторону треугольника b: ");
int c = ReadData("Введите сторону треугольника c: ");

//3 4 5
PrintResult(TrglTest(a, b, c) ? "Такой треугольник существует" : "Такого треугольника не существует");