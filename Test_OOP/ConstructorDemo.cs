using System;

namespace Test_OOP;

public class ConstructorDemo
{
    public static int x;
    public int y;

    static ConstructorDemo()
    {
        System.Console.WriteLine("Static Constructor is Called");
    }

    public ConstructorDemo()
    {
        System.Console.WriteLine("Non-Static Constructor is Called");
    }
}
