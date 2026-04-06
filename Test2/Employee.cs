using System;

namespace Test2;

public class Employee
{
    public int x;

    public Employee(int i)
    {
        x = i;
    }
    
    public Employee(Employee obj)
    {
        x = obj.x;
    }


    public void Display()
    {
        Console.WriteLine($"Value of X = {x}");
    }
}
