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
int sumNum(int num)
{
    //int count = 0;
    int sum = 0;
    //if (num == 0) return count = 1;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
        //count++;
    }
    return sum;
}

Console.Clear();
int userNumber = enterNumber("Введите целое число:  ", "Введите целое число");
Console.WriteLine($"{userNumber} -> {sumNum(userNumber)}");