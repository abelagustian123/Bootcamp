using System;

namespace Test_OOP;

public class ParameterizedConstructor
{
    public int _x;
    
    public int X{get => _x; set => _x = value;}

    public ParameterizedConstructor(int i)
    {
        X = i;
        System.Console.WriteLine($"Parameterized Constructor is Called: {i}");
    }

    public void Display()
    {
        System.Console.WriteLine($"Value of X = {X}");
    }
}
