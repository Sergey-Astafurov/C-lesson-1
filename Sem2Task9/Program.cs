
System.Random numberGenetator = new System.Random();
int number = numberGenetator.Next(10, 100);
Console.WriteLine(number);

int firstDigit = number / 10;
Console.WriteLine(firstDigit);

int secondDigit = number % 10;
Console.WriteLine(secondDigit);

if (firstDigit > secondDigit)
{
   Console.WriteLine(firstDigit);
}
else
{
   Console.WriteLine(secondDigit);
}