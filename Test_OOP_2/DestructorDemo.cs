using System;

namespace Test_OOP_2;

public class DestructorDemo
{
    public DestructorDemo()
    {
        Console.WriteLine("DestructorDemo Object Created");
    }

    ~DestructorDemo()
    {
        Console.WriteLine("DestructorDemo Object Destroyed");
    }
}
