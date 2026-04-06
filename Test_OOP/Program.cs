//Class is a definition and objects are instances
/*
Example:
If we take examples of human beings, it is a class. There’s a class human and you are an object of human being class. The BMW is a car and Toyota is also a car. These are the objects of class cars.
*/

/*
Fungsi utama dari static method adalah untuk menyediakan tugas atau perilaku yang berdiri sendiri dan menjadi milik class itu sendiri, bukan milik objek (instance) spesifik yang dicetak dari class tersebut. Karena milik class, kamu bisa memanggilnya tanpa harus membuat objeknya
*/


using Test_OOP;

// Employee e1 = new Employee(101, 30, "Pranaya", "Mumbai", true);
// e1.Display();
// System.Console.WriteLine();

// Employee e2 = new Employee(e1);
// e2.Display();


// ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
// obj1.Display();


// CopyConstructor obj1 = new CopyConstructor(10);
// obj1.Display();

// CopyConstructor obj2 = new CopyConstructor(obj1);
// obj2.Display();

// Console.ReadKey();



// First f1 = new First();
// First f2 = new First();
// First f3 = new First();
// Console.WriteLine($"{f1.x}   {f2.x}   {f3.x}");

// Second s1 = new Second(100);
// Second s2 = new Second(200);
// Second s3 = new Second(300);
// System.Console.WriteLine($"{s1.x}   {s2.x}   {s3.x}");

// StaticConstructorDemo sc1 = new StaticConstructorDemo();

// sc1.Increment();
// sc1.Display();
// sc1.Increment();
// sc1.Display();

// StaticConstructorDemo sc2 = new StaticConstructorDemo();
// sc2.Increment();
// sc2.Display();
// sc2.Increment();
// sc2.Display();

// System.Console.WriteLine("Main Method Body..");

// ConstructorDemo obj1 = new ConstructorDemo();
// ConstructorDemo obj2 = new ConstructorDemo();
// ConstructorDemo obj3 = new ConstructorDemo();


// System.Console.WriteLine("Main Method Completed");


PrivateConstructorDemo fromPlace1 = PrivateConstructorDemo.GetSingletonInstance();
fromPlace1.SomeMethod("From Place 1");
PrivateConstructorDemo fromPlace2 = PrivateConstructorDemo.GetSingletonInstance();
fromPlace2.SomeMethod("From Place 2");
Console.ReadKey();
