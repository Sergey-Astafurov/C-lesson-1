// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
int ReadData(string line)
{

   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;

}
double CalculateDistance(int x1,int y1,int x2,int y2, int z1, int z2)
{
   double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

   return distance;
}
void PrintResult(string line)
{
   Console.WriteLine(line);
}

int x1 = ReadData("Введи х 1 точки");
int y1 = ReadData("Введи у 1 точки");
int x2 = ReadData("Введи х 2 точки");
int y2 = ReadData("Введи у 2 точки");
int z1 = ReadData("Введи z 1 точки");
int z2 = ReadData("Введи z 2 точки");
double result =  Math.Round(CalculateDistance(x1,y1,x2,y2,z1,z2)) ;

PrintResult("Расстояние между точками : " + result);