int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}
int RecMN(int m, int n)
{
   if (m > n) return RecMN(n, m);

   if (m >= n) return n;
   return m + RecMN(m + 1, n);

}


void PrintResult(int line)
{
   Console.WriteLine(line);
}

int n = ReadData("Введи число");
int m = ReadData("Введи число");
int nums = RecMN(n, m);
PrintResult(nums);