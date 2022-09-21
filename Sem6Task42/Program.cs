
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
// Создаем метод с циклом
string BinConvert(int a)
{
   string result = string.Empty;
   while (a > 0)
   {
      result = result + a % 2;
      a = a / 2;
   }

   return result;
}
// Вызов результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}

int a = ReadData("Введи число");

string Bincon = BinConvert(a);
PrintResult("ответ: " + Bincon); // выввод результата


