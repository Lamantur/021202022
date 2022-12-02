int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
bool Polindrom(int number)
{
    if (number / 10000 == number % 10 && number / 1000 - (number / 10000) * 10 == (number / 10) % 10)
    {
        return true;
    }
    else return false;
}

if (Polindrom(Prompt("Введите пятизначное число:"))) { System.Console.WriteLine("ДА"); }
else { System.Console.WriteLine("НЕТ"); }