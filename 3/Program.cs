int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int i = 1;
int N = Prompt("Введите число");
while (i < N)
{
    System.Console.Write(i * i * i + ",");
    i++;

}
System.Console.Write(N * N * N);