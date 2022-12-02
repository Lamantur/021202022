int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}


int x1 = Prompt("Введите координату Х первой точки");
int y1 = Prompt("Введите координату y первой точки");
int z1 = Prompt("Введите координату z первой точки");
int x2 = Prompt("Введите координату Х второй точки");
int y2 = Prompt("Введите координату y второй точки");
int z2 = Prompt("Введите координату z второй точки");

double AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
System.Console.WriteLine("Расстояние между точками: " + AB);