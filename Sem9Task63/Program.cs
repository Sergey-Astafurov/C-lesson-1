int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}
string LineGenRec(int numN)
{
   if (numN == 0) return " ";

   return LineGenRec(numN - 1) +  " " + numN ;

}


void PrintResult(string line)
{
   Console.WriteLine(line);
}

int n = ReadData("Введи число");
string nums = LineGenRec(n);
PrintResult(nums);