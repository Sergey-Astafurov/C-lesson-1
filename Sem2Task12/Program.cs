string? A = Console.ReadLine();
string? b = Console.ReadLine();

int inputLineA = int.Parse(A);
int inputLineb = int.Parse(b);

Console.WriteLine((inputLineb % inputLineA == 0) ? ("второе чилсо кратно") : ("Ошибка"));