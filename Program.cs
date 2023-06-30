using System;

interface INumber
{
    void Print(int number);
}

class PrintTest : INumber
{
    public void Print(int number)
    {
        Console.WriteLine("TEST");
    }
}

class PrintComplete : INumber
{
    public void Print(int number)
    {
        Console.WriteLine("COMPLETE");
    }
}

class PrintTestComplete : INumber
{
    public void Print(int number)
    {
        Console.WriteLine("TEST COMPLETE");
    }
}

class NumberWisePrint
{

    public void PrintNumber(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
            new PrintTestComplete().Print(number);
        else if (number % 3 == 0)
            new PrintTest().Print(number);
        else if (number % 5 == 0)
            new PrintComplete().Print(number);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Number: ");
        int n = int.Parse(Console.ReadLine());

        NumberWisePrint _obj = new NumberWisePrint();
        for (int num = 0; num <= n; num++)
        {
            _obj.PrintNumber(num);
        }
    }
}
