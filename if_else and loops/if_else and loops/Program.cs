
////1.musbat va manfiy sonni aniqlash
//int son = int.Parse(Console.ReadLine()!);
//if (son > 0)
//{
//    Console.WriteLine("musbat son");
//}
//else if (son < 0)
//{
//    Console.WriteLine("manfiy son");
//}
//else
//{
//    Console.WriteLine("son nolga teng");
//}

////2.yosh tekshirish
//int a = int.Parse(Console.ReadLine()!);
//if (a >= 18)
//{
//    Console.WriteLine("kattasiz");
//}
//else
//{
//    Console.WriteLine("voyaga yetmagansiz");
//}

////3.parollarni tekshirish
//string parol1 = "code123";
//if (parol1 == Console.ReadLine()!.Trim())
//{
//    Console.WriteLine("parol to'g'ri");
//}
//else
//{
//    Console.WriteLine("parol noto'g'ri");
//}

////4.juft yoki toq sonni aniqlash
//int son1 = int.Parse(Console.ReadLine());
//if (son1 % 2 == 0)
//{
//    Console.WriteLine("juft son");
//}
//else
//{
//    Console.WriteLine("toq son");
//}

////5 temperatura tekshirish

//int a3 = int.Parse(Console.ReadLine()!);
//if (a3 >= 25)
//{
//    Console.WriteLine("issiq!");
//}
//else
//{
//    Console.WriteLine("salqin!");
//}

////6. reytingni aniqlash
//int ball = int.Parse(Console.ReadLine()!);
//if (ball >= 90 && ball <= 100) 
//    Console.WriteLine("A");
//else if (ball >= 70)
//    Console.WriteLine("B");
//else if (ball >= 50)
//    Console.WriteLine("C");
//else if (ball >= 0)
//    Console.WriteLine("D");
//else
//    Console.WriteLine("xato");

//// 7 . login va parolni tekshirish
//string login = "admin";
//string parol = "12345";
//if (login == Console.ReadLine())
//{
//    if (parol == Console.ReadLine())
//    {
//        Console.WriteLine("xush kelibsiz");
//    }
//    else
//    {
//        Console.WriteLine("parol noto'g'ri");
//    }
//}
//else
//{
//    Console.WriteLine("login noto'g'ri");
//}

//// 8. uchburchak aniqlash
//int a1 = int.Parse(Console.ReadLine()!);
//int b1 = int.Parse(Console.ReadLine()!);
//int c1 = int.Parse(Console.ReadLine()!);

//if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
//{
//    Console.WriteLine("uchburchak hosil bo'ladi");
//}
//else
//{
//    Console.WriteLine("uchburchak hosil bo'lmaydi");
//}

////9. harorat tekshirish
//int temprature = int.Parse(Console.ReadLine()!);
//if (temprature > 35)
//    Console.WriteLine("Havfli issiq!");
//else if (temprature > 20)
//    Console.WriteLine("Yoqimli");
//else if (temprature > 10)
//    Console.WriteLine("Salqin!");
//else
//    Console.WriteLine("Sovuq!");

////10.foydalanuvchi ismi uzunligini aniqlash
//string ism = Console.ReadLine()!;
//if (ism.Length < 5)
//{
//    Console.WriteLine("Ism juda qisqa");
//}
//else if (ism.Length == 5)
//{
//    Console.WriteLine("Ism o'rtacha uzunlikda");
//}
//else
//{
//    Console.WriteLine("Ism juda uzun");
//}

//// 11 balansdan pul yechish
//int balans = int.Parse(Console.ReadLine()!);
//int vivod = int.Parse(Console.ReadLine()!);

//double komissiya = vivod * 0.05;   // 5% komissiya
//double jami = vivod + komissiya;   // chiqarilishi kerak bo'lgan summa

//if (balans >= jami)
//{
//    Console.WriteLine("operatsiya muvofaqqiyatli");
//}
//else
//{
//    Console.WriteLine("balansda yetarli mablag' yo'q");
//}

//// 12. telifon raqamini tekshirish
//string tel = Console.ReadLine()!;

//if (tel.StartsWith("+998")) // startsWith -  metodi berilgan qator shu bilan boshlanadimi tekshiradi
//    Console.WriteLine("O'zbek raqami");
//else
//    Console.WriteLine("Chet el raqami");

//// 13.yosh toifasini aniqlash
//int age = int.Parse(Console.ReadLine()!);

//if (age >= 0 && age <= 12)
//    Console.WriteLine("Bolalar");
//else if (age <= 19)
//    Console.WriteLine("O'smir");
//else if (age <= 59)
//    Console.WriteLine("Katta yosh");
//else
//    Console.WriteLine("Qariya");


// LOOPS

//1. 1 dan 10 gacha bo'lgan sonlarni chiqarish
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//2 . foydalanuvchidan soz olib 3 marta chiqarish
//string soz = Console.ReadLine()!;
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(soz);
//}
//3. 1 dan n gacha bo'lgan sonlarni chiqarish
//int n = int.Parse(Console.ReadLine()!);
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);
//4. 1 dan m gacha bo'lgan juft sonlarni chiqarish

//int m = int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//5 . foydalanuvchi 0 kiritmaguncha sonlarni qabul qilaverish
//int x;
//do
//{
//    x = int.Parse(Console.ReadLine()!);
//} while (x != 0);

//6.1 dan 50 gacha 3 ga bo‘linadigan sonlar

//for (int i = 1; i <= 50; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//7.Foydalanuvchi bergan sondan 1 gacha teskari sanash

//int son2 = int.Parse(Console.ReadLine()!);
//for (int i = son2; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}   

//8 Matn ichidagi harflar sonini hisoblang
//string matn = Console.ReadLine()!;
//int harfSoni = 0;
//for (int i = 0; i < matn.Length; i++)
//{
//    if (char.IsLetter(matn[i]))  // agar belgi harf bo'lsa true,raqam va boshqa belgilarga false qaytaradi
//    {
//        harfSoni++;
//    }
//}
//Console.WriteLine(harfSoni);

//9 kopaytirish jadvali
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write(i * j + "\t");
//    }
//    Console.WriteLine();
//}

//10. 1 dan n gacha kvadratlar yig‘indisi

//int n = int.Parse(Console.ReadLine()!);
//int sum = 0;

//for (int i = 1; i <= n; i++)
//    sum += i * i;

//Console.WriteLine(sum);

