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
int[] fillArray_1()
{
    int N = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = enterNumber("Введите элемент массива:  ", "Введите целое число");
    }
    return array;
}
int[] fillArray_2()
{
    int[] array = new int[0];
    string userChar = "start";
    int tmp;
    int ind = 0;
    Console.WriteLine("Вводите элементы массива после приглашения.");
    Console.WriteLine("Для окончания ввода введите q или Q");
    while (true)
    {
        Console.Write("Введите элемент массива:  ");
        userChar = Console.ReadLine() ?? "";
        if (int.TryParse(userChar, out tmp))
        {
            Array.Resize(ref array, array.Length + 1);
            array[ind] = tmp;
            ind++;
        }
        else
        {
            if (userChar == "q" || userChar == "Q")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
        }

    }
    return array;
}

int[] userArray1 = fillArray_1();
Console.WriteLine($"{String.Join(", ", userArray1)} -> [{String.Join(", ", userArray1)}]");

int[] userArray2 = fillArray_2();
Console.WriteLine($"{String.Join(", ", userArray2)} -> [{String.Join(", ", userArray2)}]");