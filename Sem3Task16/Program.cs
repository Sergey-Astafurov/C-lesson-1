

int ReadData(string line)
{

   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}

bool SqTest(int first, int second)
{
   if (first == second * second)
   {
      return true;
   }
   else
   {
      return false;
   }
}

void PrintData(int first, int second)
{
   if (SqTest(first, second))
   {
      Console.WriteLine("число " + first + " квадрат числа " + second);
   }
   else
   {

      Console.WriteLine("число " + first + " НЕ квадрат числа " + second);
   }
}

int num1= ReadData("Введите число 1");
int num2= ReadData("Введите число 2");
PrintData(num1, num2);
PrintData(num2, num1);

