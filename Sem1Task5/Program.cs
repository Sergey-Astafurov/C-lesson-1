//на вход принимает число и на выходе показывает все целые числа от -н до н

string? inputLineN = Console.ReadLine();
if (inputLineN != null)
{
   int inputNumberN = int.Parse(inputLineN);

   int startNumber = (-1) * inputNumberN;
   while (startNumber < inputNumberN)
   {
      Console.Write(startNumber + ", ");
      startNumber++;
   }
   Console.Write(inputNumberN);

}