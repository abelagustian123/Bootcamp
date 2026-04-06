using System;
using System.Diagnostics.Contracts;

namespace Test_OOP;

public sealed class PrivateConstructorDemo
{
    private static int counter = 0;
    private static PrivateConstructorDemo instance = null;
    private static readonly object Instancelock = new object();
    public static PrivateConstructorDemo GetSingletonInstance()
    {
        lock (Instancelock)
        {
            if (instance == null)
            {
                instance = new PrivateConstructorDemo();
            }
            return instance;
        }
    }

    private PrivateConstructorDemo()
    {
        counter++;
        Console.WriteLine($"Singleton Constructor Executed {counter} Time");
    }
    public void SomeMethod(string Message)
    {
        Console.WriteLine($"Some Method Called : {Message}");
    }
}
