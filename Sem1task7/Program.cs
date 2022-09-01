//на вход принимает трехзначное число и на выходе показывает его последнюю цифру

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
   int inputNumberN = int.Parse(inputLine);
   if(inputNumberN > 99 && inputNumberN < 1000)
   {
      int lastDigit = inputNumberN % 10;
       Console.Write(lastDigit);
   }



}