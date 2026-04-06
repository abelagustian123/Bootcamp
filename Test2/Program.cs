// static void CheckValue(object x)
// {
//     switch (x)
//     {
//         // Cek jika tipe int DAN nilainya di atas 100
//         // When itu untuk mengecek kondisinya 
//         // misal int dan nilai int tersebut > 100
//         case int n when n > 100:
//             Console.WriteLine($"{n} adalah angka yang sangat besar!");
//             break;

//         // Cek jika tipe int DAN nilainya negatif
//         case int n when n < 0:
//             Console.WriteLine($"{n} adalah angka negatif.");
//             break;

//         // Jika tipe int tapi tidak memenuhi kriteria 'when' di atas
//         case int n:
//             Console.WriteLine($"{n} adalah angka standar.");
//             break;

//         case string s when s.Length > 10:
//             Console.WriteLine("Ini teks yang panjang.");
//             break;

//         default:
//             Console.WriteLine("Tipe data lain atau tidak memenuhi kriteria.");
//             break;
//     }
// }

// CheckValue(101);
// CheckValue(-1);
// CheckValue(4);
// CheckValue("ini angka 100 dan lebih dari 10 kata");
// CheckValue(false);

// string level = "gold";
// int belanja = 100_000;

// double diskon = level switch
// {
//     "gold" => 0.2,
//     "silver" => 0.1,
//     "bronze" => 0.05,
//     _ => 0.0 //default value
// };

// double totalBayar = belanja - (belanja * diskon);

// System.Console.WriteLine($"Member: {level}");
// System.Console.WriteLine($"Diskon: {diskon * 100}%");
// System.Console.WriteLine($"Total bayar: Rp{totalBayar}");


// using System.Text;

// StringBuilder sb = null;
// string voidString = "nothing";
// string voidBuilderString = "Builder Nothing";

// string myVariable = null;

// string sBuilder = sb?.ToString() ?? voidBuilderString;
// string s = myVariable ??= voidString;

// System.Console.WriteLine(s);
// System.Console.WriteLine(sBuilder);

/*
is untuk membandingkan
as untuk convert

contoh is itu if (7 is 7) hasil true
atau if (7 is 3) hasil false

object benda =123l
contoh as, string s = object as string; 

*/

/*
perbedaan & adn &&
contoh & -> (1 > 5 & 10 / 0 == 0) hasil error devide by zero karena dia cek semuanya, sesudah cek 1>5 false, lalu cek 10/0 hasil error devide by zero

kalau && -> misal (1 > 5 & 10 / 0 == 0) hasil false karena di 1<5 hasil sudah false

*/




void Split(string name, out string firstName, out string lastName)
{
    int i = name.LastIndexOf(' ');
    firstName = name.Substring(0, i);
    lastName = name.Substring(i + 1);
}


string a,b;
Split("Stevie Ray Vaughan", out a, out _);
System.Console.WriteLine(a);

float fA = 3.0f;
float fB = 0.0f;

System.Console.WriteLine(fA/fB);


// int aInteger = 0;
// bool bBool = (bool)aInteger;

// System.Console.WriteLine(bBool);
// int zero = 0;
// bool bBool = (2>10) & (10/zero == 3) || 3<1;
// System.Console.WriteLine(bBool);

bool bo = true;
Console.WriteLine($"The answer in binary is {(bo ? 1 : 0)}"); // Uses a ternary operator