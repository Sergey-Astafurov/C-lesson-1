int ReadData(string line)
{

   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}
string LineNumbers(int N, int pow)
{
   int i = 0;
   string outLine = string.Empty;
   while (i < N)
   {
      outLine = outLine + Math.Pow(i, pow) + "|\t|";
      ++i;
   }
   outLine = "|" + outLine + Math.Pow(N, pow) + "|"; ;
   return outLine;
}

void PrintResult(string line)
{
   Console.WriteLine(line);
}

int enterN = ReadData("Введи число");
PrintResult(LineNumbers(enterN, 1));
PrintResult(LineNumbers(enterN, 2));