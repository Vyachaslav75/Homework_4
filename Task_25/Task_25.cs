int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}
Console.Clear();
int A = enterNumber("Введите число А:  ", "Введите целое число");
int B = enterNumber("Введите число В:  ", "Введите целое число");
Console.WriteLine($"{A}, {B} -> {Math.Pow(A, B)}");