// See https://aka.ms/new-console-template for more information
// Add() - qo'shish 
// Count - list uzunligi
// Remove - elementlarni o'chirish
// RemoveAt - index uyicha uchiradi
// Clear() - ruyxatni tozalash
// Sort() - listni o'sish tartibida sortlash 
// Reverse -  teskari tartibda  sortlash 
// Contains - element bor yo'qligini tekshirish 

//List<string> ismlar = new List<string>();

//for (int i = 0; i < 5; i++)
//{
//    string ism = Console.ReadLine();
//    ismlar.Add(ism);
//}

//foreach (var ism in ismlar)
//{
//    Console.WriteLine(ism);
//}

// Listdagi eng katta sonni topish 

//List<int> sonlar = new List<int>() { 4546, 32, 454, 1, 34 };
//int max = sonlar[0];
//foreach(var s in sonlar)
//{
//    if(s>max)
//    {
//        max = s;
//    }
//}
//Console.WriteLine("Eng katta son : "+max);

// 

//List<int> nums = new List<int>();

//while (true)
//{
//    int n = int.Parse(Console.ReadLine());

//    if (n == 0) break;

//    nums.Add(n);
//}

//foreach (var x in nums)
//{
//    Console.WriteLine(x);
//}

//List<int> son = new List<int>();

//son.Add(10);
//son.Add(20);
//son.Add(30);
//son.Add(40);
//son.Add(50);

//foreach (int s1 in son)
//{
//    Console.WriteLine(s1);
//}

// Listga element qo'shib o'chirish

//List<int> sonlar1 = new List<int>() { 1, 2, 3, 4 };

//sonlar1.Add(5);       // 5 qo‘shildi
//sonlar1.Remove(3);    // 3 qiymatiga teng element o‘chirildi

//foreach (var s2 in sonlar1)
//{
//    Console.WriteLine(s2);
//}

// 10 ta tasodifiy son chiqarish 

//List<int> num = new List<int>();
//Random r = new Random();

//for (int i = 0; i<10 ;i++)
//{
//    int  n  = r.Next(1, 100);
//    num.Add(n);
//}
//foreach(var abs in num )
//{
//    Console.WriteLine(abs);
//}

// Listdagi eng kichik sonni topish 

//List<int> number = new List<int>() { 233, 435, 5454, 33, 23, 3 };
//int min = number[0];

//foreach(var v in number)
//{
//    if (v<min)
//    {
//        min = v;
//    }
//}
//Console.WriteLine("Eng kichik son ! "+ min);

//// Listni o'sish tartibida sort qilish

//List<int> sonlar = new List<int>() { 30, 5, 12, 100, 44 };

//sonlar.Sort();   // o‘sish tartibi

//foreach (var s in sonlar)
//{
//    Console.WriteLine(s);
//}

//
//List<int> sonlar = new List<int>() { 1, 2, 3, 2, 4, 3, 5 };

//List<int> unikal = new List<int>();

//foreach (int son in sonlar)
//{
//    if (!unikal.Contains(son))
//    {
//        unikal.Add(son);
//    }
//}

//Console.WriteLine("Unikal sonlar:");
//foreach (int s in unikal)
//{
//    Console.WriteLine(s);
//}

// Ikki Listni birlashtirib  va o‘sish tartibida tartiblash.

//List<int> list1 = new List<int>() { 7, 2, 9 };
//List<int> list2 = new List<int>() { 1, 5, 3 };

//list1.AddRange(list2);   // birlashtirdik
//list1.Sort();            // tartiblash

//Console.WriteLine("Birlashtirilgan va tartiblangan ro'yxat:");
//foreach (int x in list1)
//{
//    Console.WriteLine(x);
//}

//List ichidagi juft sonlarni ajratib olish 

//List<int> sonlar = new List<int>() { 3, 8, 12, 5, 7, 10 };

//List<int> juftlar = new List<int>();

//foreach (int x in sonlar)
//{
//    if (x % 2 == 0)
//    {
//        juftlar.Add(x);
//    }
//}

//Console.WriteLine("Juft sonlar:");
//foreach (int j in juftlar)
//{
//    Console.WriteLine(j);
//}

// Listni teskari tartibda chiqarish (remove) ishlatmasdan.

List<int> rem = new List<int>() { 1, 2, 3, 4, 5, 6, 7, };
for(int i = rem.Count - 1; i >= 0; i--)
{
    Console.WriteLine(rem[i]);
}
