using System.Text;
using LogicExercise4;

FooBarGenerator fooBarGenerator = new FooBarGenerator();
Console.WriteLine("======= Add Rules =======");
AddRules();

System.Console.WriteLine("\n======= Remove Rules =======");
RemoveRules();


System.Console.WriteLine("\n======= Angka yang akan digenerate =======");
Console.Write("Input jumlah angka: ");
string inputNumber = Console.ReadLine();
GenerateAngka(inputNumber);



void AddRules()
{
    while (true)
    {
        Console.Write("Input angka (ketik selesai jika sudah menambah rules): ");
        string inputAngka = Console.ReadLine();

        if (inputAngka == "selesai")
        {
            listRules();
            break;
        }

        if (!int.TryParse(inputAngka, out int angka) || angka < 0)

            System.Console.WriteLine("Input tidak valid, input ulang");
        else
        {
            Console.Write("Input kata: ");
            string? inputKata = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(inputKata))
            {
                System.Console.WriteLine("Input kata tidak boleh null");
            }
            else
                fooBarGenerator.AddRule(angka, inputKata);
        }
    }
}

void RemoveRules()
{
    while (true)
    {
        Console.Write("Apakah ingin menghapus salah satu rule? (ya/tidak) ");
        string inputOption = Console.ReadLine().Trim().ToLower();

        if (inputOption == "ya")
        {
            Console.Write("Input angka rules yang ingin dihapus: ");
            string numRemove = Console.ReadLine();

            if (!int.TryParse(numRemove, out int remove))
            {
                System.Console.WriteLine("Input tidak valid");
            }
            else
            {
                if (fooBarGenerator.rules.ContainsKey(remove))
                {
                    fooBarGenerator.RemoveRule(remove);
                    System.Console.WriteLine($"{remove} sudah terhapus dari list rules");
                }
                else
                {
                    System.Console.WriteLine("Angka tersebut tidak ada di list");
                }
            }
        }
        else if (inputOption == "tidak")
        {
            System.Console.WriteLine("Rules terbaru");
            listRules();
            break;
        }
        else
        {
            System.Console.WriteLine("Input tidak valid, hanya ya/tidak");
        }
    }
}

void GenerateAngka(string inputNumber)
{

    if ((!int.TryParse(inputNumber, out int number)) || number <= 0)
        System.Console.WriteLine("Input tidak valid. Silakan input angka 1 atau lebih besar.");
    else
    {
        string outputs = fooBarGenerator.Generate(number);
        System.Console.WriteLine("\nHasil FooBar: ");
        System.Console.WriteLine(outputs);
    }
}

void listRules()
{
    System.Console.WriteLine("====== List Rules ======");
    foreach (var list in fooBarGenerator.rules)
    {
        System.Console.WriteLine($"Angka: {list.Key}, Rules: {list.Value}");
    }
}