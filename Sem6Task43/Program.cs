
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}

// находим точки пересечения
(double, double) PointFind(int b1, int k1, int b2, int k2)
{
   double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
   double y = (double)k1 * x + (double)b1;
   return (x, y);
}

// вывод результата
void PrintResultArray((double, double) arr)
{
   Console.WriteLine(arr);
}
//Тело программы
int b1 = ReadData("Введи число b1");
int k1 = ReadData("Введи число k1");
int b2 = ReadData("Введи число b2");
int k2 = ReadData("Введи число k2");
(double, double) points = PointFind(b1, k1, b2, k2); // вычисления
PrintResultArray(points);

