int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
long MultA(int num){
   int i = 1;
   int sum = 1;
   while ( i <= num){
      sum = sum * i;
      i++;
   }
   return sum;

}


void PrintResult(string line)
{
   Console.WriteLine(line);
}

int numberA = ReadData("Введи число");
long res = MultA(numberA);
PrintResult("Сумма произведений " + res);
