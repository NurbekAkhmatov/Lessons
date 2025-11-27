// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("1-7 oralig'ida son kiriting! ");
int n = int.Parse(Console.ReadLine()!);

switch(n)
{
    case 1:
        Console.WriteLine("Dushanba");
        break;

    case 2:
        Console.WriteLine("Seshanba");
        break;
    case 3:
        Console.WriteLine("Chorshanba");
        break;
    case 4:
        Console.WriteLine("Payshanba");
        break;
    case 5:
        Console.WriteLine("Juma");
        break;
    case 6:
        Console.WriteLine("Shanba");
        break;
    case 7:
        Console.WriteLine("Yakshanba");
        break;
    default:
        Console.WriteLine("1-7 oralig'ida son kirit");
        break;
}

// Arfmetik amallar kankulyatori:
Console.Write("1-son: ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("2-son: ");
double b = double.Parse(Console.ReadLine()!);

Console.Write("Amal (+ - * /): ");
char amal = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (amal)
{
    case '+':
        Console.WriteLine(a + b);
        break;

    case '-':
        Console.WriteLine(a - b);
        break;

    case '*':
        Console.WriteLine(a * b);
        break;

    case '/':
        if (b == 0)
            Console.WriteLine("0 ga bo‘lish mumkin emas!");
        else
            Console.WriteLine(a / b);
        break;

    default:
        Console.WriteLine("Noto‘g‘ri amal!");
        break;
}
// bahoni harfga o'tqazish
Console.Write("Bahoni kiriting (A,B,C,D,F): ");
char grade = char.Parse(Console.ReadLine()!.ToUpper());

switch (grade)
{
    case 'A':
        Console.WriteLine("A'lo");
        break;
    case 'B':
        Console.WriteLine("Yaxshi");
        break;
    case 'C':
        Console.WriteLine("Qoniqarli");
        break;
    case 'D':
        Console.WriteLine("Past");
        break;
    case 'F':
        Console.WriteLine("Yomon");
        break;

    default:
        Console.WriteLine("Bunday baho mavjud emas!");
        break;
}
// Kichik memyuli sestima 

Console.WriteLine("=== MENYU ===");
Console.WriteLine("1. Yig'indi");
Console.WriteLine("2. Ko'paytma");
Console.WriteLine("3. Kvadrat");
Console.WriteLine("0. Chiqish");
Console.Write("Tanlang: ");

int tanlov = int.Parse(Console.ReadLine()!);

switch (tanlov)
{
    case 1:
        Console.Write("A = ");
        int a1 = int.Parse(Console.ReadLine()!);
        Console.Write("B = ");
        int b1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Yig'indi = {a1 + b1}");
        break;

    case 2:
        Console.Write("A = ");
        int c = int.Parse(Console.ReadLine()!);
        Console.Write("B = ");
        int d = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Ko'paytma = {c * d}");
        break;

    case 3:
        Console.Write("Son = ");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Kvadrati = {x * x}");
        break;

    case 0:
        Console.WriteLine("Dastur tugadi");
        break;

    default:
        Console.WriteLine("Noto‘g‘ri tanlov!");
        break;
}

