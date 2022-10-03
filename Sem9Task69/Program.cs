int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}
int RecPow(int A, int B)
{
   if (B == 0) return 1;
   int pow = A * RecPow(A, B - 1);
   return pow;

}


void PrintResult(int line)
{
   Console.WriteLine(line);
}

int n = ReadData("Введи число");
int s = ReadData("Введи число");
int nums = RecPow(n, s);
PrintResult(nums);