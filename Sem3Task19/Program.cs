// int ReadData(string line)
// {
//    Console.WriteLine(line);
//    int number = int.Parse(Console.ReadLine() ?? "0");
//    return number;

// }

// bool PalindTest(int palindrom)
// {
//    if (palindrom / 10000 == palindrom % 10 && palindrom / 1000 % 10 == palindrom/10 % 10)
//    {
//       return true;
//    }
//    return false;
// }


// int palindrom = ReadData("Введите число");
// bool CalculateP = PalindTest(palindrom);
// result();

// void result(){
//    if(CalculateP){
//       Console.WriteLine("Это палиндром");
//    }else{
//       Console.WriteLine("Это не палиндром");
//    }
// }

// metod lilia

double ReadData(string line)
{
   Console.WriteLine(line);
   double number = double.Parse(Console.ReadLine() ?? "0");
   return number;

}

bool palindromTest(double a){
   char[] charArray = a.ToString().ToCharArray();
   Array.Reverse(charArray);
   double reverseArray = double.Parse(charArray);
   Console.WriteLine(reverseArray);

   if ( reverseArray == a) {
      return true;
   }else {
      return false;
   }
}
void PrintResult(bool res) {
   if(res){
      Console.WriteLine("palindr");
   }else{
      Console.WriteLine("NoT_palindr");

   }
}

double inputNumber = ReadData("Введи число");
bool res = palindromTest(inputNumber);
PrintResult(res);

