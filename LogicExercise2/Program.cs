string inputNumber = Console.ReadLine();

if (!int.TryParse(inputNumber, out int number))
    System.Console.WriteLine("input harus angka");
else
{
    for(int i = 1; i <= number; i++)
    {
        string s = "";
        if(i % 3 == 0)
            s += "foo";
        if(i % 5 == 0)
            s += "bar";
        if(i % 7 == 0)
            s += "jazz";

        if (string.IsNullOrEmpty(s))
            System.Console.Write(i);
        else
            System.Console.Write(s);

        if (i < number) System.Console.Write(",");
    }
}