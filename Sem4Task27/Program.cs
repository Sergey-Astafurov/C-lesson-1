
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
// Создаем метод с циклом
int SumNum(int num)
{
   int result = 0;
   while (num > 0) // проводим цикл пока число не дойдет до нуля
   {
      result = result + num % 10; // сложение идет с конца (1234  =>  4, 3, 2, 1)
      num = num / 10; // тут уменьшаем число на десяток
   }
   return result;
}
// Вызов результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}
int num = ReadData("Введи число");// ввод переменной
int ColculateSum = SumNum(num); // вычисления
PrintResult("ответ: " + ColculateSum); // выввод результата


