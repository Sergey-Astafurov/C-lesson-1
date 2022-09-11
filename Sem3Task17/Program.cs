

int ReadData(string line)
{

   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}
int QueterTest(int x, int y)
{
   if (x > 0 && y > 0)
      return 1;
   if (x < 0 && y > 0)
      return 2;
   if (x < 0 && y < 0)
      return 3;
   if (x > 0 && y < 0)
      return 4;

   return 0;
}

void PrintResult(string line)
{
   Console.WriteLine(line);
}

int x = ReadData("Введи координату х");
int y = ReadData("Введи координату y");
int result = QueterTest(x, y);
PrintResult("Точка находится в четверти номер : " + result);

