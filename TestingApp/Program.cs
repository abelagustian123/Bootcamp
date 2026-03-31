using System.Globalization;

string inputNumber = Console.ReadLine();

if (!int.TryParse(inputNumber, out int number))
{
    System.Console.WriteLine("input harus angka");
}
else
{
    for(int i = 1; i <= number; i++)
    {
        if((i % 3 == 0) && (i % 5 == 0))
            System.Console.Write("foobar");
        else if(i % 3 == 0)
            System.Console.Write("foo, ");
        else if(i % 5 == 0)
            System.Console.Write("bar, ");
        else 
            System.Console.Write(i+", ");
    }
}

