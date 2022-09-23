// ===============================================================
// #43 Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых
// ===============================================================

//чтение данных пользователя
double ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    double number = double.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);

}
double[] PointFind(double k1, double k2, double b1, double b2)
{

    double[] array = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    array[0] = x;
    array[1] = y;
    return array;
}

//сама программа
//PrintResult("Точка пересечения двух прямых: " + PointFind(ReadData("Введите число k1: "), ReadData("Введите число k2: "),ReadData("Введите число b1: "),ReadData("Введите число b2: ")));
double[] coordinate = PointFind(ReadData("Введите число k1: "), ReadData("Введите число k2: "), ReadData("Введите число b1: "), ReadData("Введите число b2: "));
PrintResult("Точка пересечения двух прямых: " + coordinate[0] + ";" + coordinate[1]);

