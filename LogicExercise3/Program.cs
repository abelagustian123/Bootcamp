using System.Text;

string inputNumber = Console.ReadLine();

if (!int.TryParse(inputNumber, out int number))
    System.Console.WriteLine("input harus angka");
else
{
    for(int i = 1; i <= number; i++)
    {
        StringBuilder? s = new StringBuilder();
        if(i % 3 == 0)
            s.Append("foo");
        if(i % 4 == 0)
            s.Append("baz");
        if(i % 5 == 0)
            s.Append("bar");
        if(i % 7 == 0)
            s.Append("jazz");
        if(i % 9 == 0)
            s.Append("huzz");

        if (s == null || s.Length == 0)
            System.Console.Write(i);
        else
            System.Console.Write(s);

        if (i < number) System.Console.Write(",");
    }
}