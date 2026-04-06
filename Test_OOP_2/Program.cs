// See https://aka.ms/new-console-template for more information

using Test_OOP_2;

// Console.WriteLine("Main Method Execution Started");

// DestructorDemo obj1 = new DestructorDemo();

//Making obj1 for Garbage Collection
Third obj = new Third();
obj = null;
GC.Collect();

Console.ReadKey();