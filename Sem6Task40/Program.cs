
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
// Создаем метод с циклом
bool Test(int a, int b, int c)
{
   bool result = false;
   if( a+b>c&& c+b>a && a+c>b){
      return true;
   }

   return result;
}
// Вызов результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}
int a = ReadData("Введи число");
int b = ReadData("Введи число");
int c = ReadData("Введи число");
bool ColculateSum = Test(a,b,c); // вычисления
PrintResult("ответ: " + ColculateSum); // выввод результата


