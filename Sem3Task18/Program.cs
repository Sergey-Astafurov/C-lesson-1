//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string line)
{

   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}
string QueterBorderAsk(int numQ)
{
   if (numQ == 1)
      return "x > 0 y < 0";
   if (numQ == 2)
      return "x < 0 y > 0";
   if (numQ == 3)
      return "x < 0 y < 0";
   if (numQ == 4)
      return "x > 0 y < 0";

   return "0";
}
void PrintResult(string line)
{
   Console.WriteLine(line);
}

int numQ = ReadData("Номер четверти :");
string result = QueterBorderAsk(numQ);
PrintResult("Точки в четверти : " + result);

