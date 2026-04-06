using System;

namespace Test_OOP;

public class StaticConstructorDemo
{
    int i;
    static int j;

    public StaticConstructorDemo()
    {
        System.Console.WriteLine("Default Constructor Executed");
        i = 100;
    }

    static StaticConstructorDemo()
    {
        System.Console.WriteLine("Static Constructor Executed");
        j = 100;
    }

    public void Increment()
    {
        i++;
        j++;
    }

    public void Display()
    {
        Console.WriteLine("Value of i : " + i);
        Console.WriteLine("Value of j : " + j);
    }
}
