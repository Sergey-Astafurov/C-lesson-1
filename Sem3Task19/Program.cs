int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}

bool PalindTest(int palindrom)
{
   if (palindrom / 10000 == palindrom % 10 && palindrom / 1000 % 10 == palindrom/10 % 10)
   {
      return true;
   }
   return false;
}


int palindrom = ReadData("Введите число");
bool CalculateP = PalindTest(palindrom);
result();

void result(){
   if(CalculateP){
      Console.WriteLine("Это палиндром");
   }else{
      Console.WriteLine("Это не палиндром");
   }
}