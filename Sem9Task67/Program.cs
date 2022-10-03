int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}
int RegSum(int numN)
{
   if (numN == 0) return 0;
   int sum = numN % 10 +  RegSum(numN/ 10);
   return sum;

}


void PrintResult(int line)
{
   Console.WriteLine(line);
}

int n = ReadData("Введи число");
int nums = RegSum(n);
PrintResult(nums);