
// 1 . Foydalanuvchi “stop” yozmaguncha matn qabul qil

//string text;
//do
//{
//    text = Console.ReadLine()!;
//}
//while (text != "stop");

//Console.WriteLine("Dastur tugadi.");

//2 .Son nechta raqamdan iborat ekanini aniqlash

//int son = int.Parse(Console.ReadLine()!);

//int count = 0;

//while (son != 0)
//{
//    son /= 10;
//    count++;
//}

//Console.WriteLine($"Raqamlar soni: {count}");

// 3 .Foydalanuvchi to‘g‘ri parol kiritmaguncha davom etsin

//string correctPassword = "12345";
//string input = "";

//while (input != correctPassword)
//{
//    Console.Write("Parolni kiriting: ");
//    input = Console.ReadLine()!;
//}

//Console.WriteLine("Parol to‘g‘ri! Xush kelibsiz!");

// 4.n gacha bo‘lgan barcha TOQ sonlar yig‘indisi

//int n = int.Parse(Console.ReadLine()!);

//int sum = 0;
//int i = 1;

//while (i <= n)
//{
//    if (i % 2 == 1)
//        sum += i;

//    i++;
//}

//Console.WriteLine(sum);

//5 .Foydalanuvchi 0 kiritmaguncha eng katta sonni toping

//int max = int.MinValue;
//int son;

//do
//{
//    son = int.Parse(Console.ReadLine()!);

//    if (son > max && son != 0)
//        max = son;

//} while (son != 0);

//Console.WriteLine($"Eng katta son: {max}");

// 6. 1 dan 50 gacha faqat 3 ga bo‘linadigan sonlarni chiqar
//int i = 1;

//while (i <= 50)
//{
//    if (i % 3 == 0)
//        Console.WriteLine(i);

//    i++;
//}

//7.Foydalanuvchi manfiy son kiritmaguncha davom etsin va kiritilgan musbat sonlar sonini sanasin

//int son;
//int count = 0;

//do
//{
//    son = int.Parse(Console.ReadLine()!);

//    if (son > 0)
//        count++;

//} while (son >= 0);

//Console.WriteLine($"Musbat sonlar soni: {count}");

// 8 .Foydalanuvchi raqamlar ketma-ketligini kiritadi . Uni teskari qilib chiqarish.
int son = int.Parse(Console.ReadLine()!);

int reverse = 0;

while (son > 0)
{
    int qoldiq = son % 10;        // oxirgi raqam
    reverse = reverse * 10 + qoldiq;
    son /= 10;                    // oxirgi raqamni olib tashlash
}

Console.WriteLine(reverse);