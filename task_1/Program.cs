// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CreateArray(int Length, int min, int max)
{
    int [] Array = new int [Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(min, max+1);
    }
    return Array;
}

int Num(string arg)
{
    System.Console.WriteLine($"Input {arg}");
    return int.Parse(Console.ReadLine());
}
int Length = Num("length array");
int min = Num("min number");
int max = Num("max number");
int [] Array = CreateArray(Length, min, max);

void PrintArray(int [] Array)
{
    System.Console.Write("[");
    for (int i = 0; i < Array.Length-1; i++)
    {
        System.Console.Write(Array[i] + "; ");
    }
    System.Console.WriteLine(Array[Array.Length-1] + "]");
}
PrintArray(Array);

int SumOddIndex(int [] Array) 
{
    int Sum = 0;
    for (int i = 1; i < Array.Length; i += 2)
    {
        Sum += Array[i];
    }
    return Sum;
}
int Sum = SumOddIndex(Array);
System.Console.WriteLine("Sum element with odd index: " + Sum);