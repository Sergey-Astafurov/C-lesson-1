int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
int sumNum(int num){
   string nums = num.ToString();
   return nums.Length;

}


void PrintResult(string line)
{
   Console.WriteLine(line);
}

int numberA = ReadData("Введи число");
int res = sumNum(numberA);
PrintResult("Колличество цифр равно " + res);
