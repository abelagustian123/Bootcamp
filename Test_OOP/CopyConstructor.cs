using System;

namespace Test_OOP;

public class CopyConstructor
{
    public int _x = 0;

    public int X {get => _x; set => _x = value;}

    public CopyConstructor(int i)
    {
        X = i;
    }

    public CopyConstructor(CopyConstructor obj)
    {
        X = obj.X;
    }

    public void Display()
    {
        System.Console.WriteLine($"Value of X = {X}");
    }
}
