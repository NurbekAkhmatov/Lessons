// See https://aka.ms/new-console-template for more information
//Massiv — bir xil turdagi ko‘p qiymatlarni bitta o‘zgaruvchida saqlash uchun ishlatiladi.

// massivni for bilan chiqarish

int[] a = { 2, 4, 6, 8 };

for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}

int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("arr[" + i + "]=");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
//massivning eng katta sonini topish

int[] arr1 = new int[5];
int max = arr1[0];

for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] > max)
    {
        max = arr1[i];
    }
}
Console.WriteLine("Eng katta son " + max);

//massivdagi juft sonlarni topish 

int[] arr2 = new int[5];

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arr2.Length; i++)
{
    if (arr2[i] % 2 == 0)
    {
        Console.WriteLine(arr2[i]);
    }

}

//massivlar yig'indisi 
int[] arr3 = new int[5];
int sum = 0;

for (int i = 0; i < arr3.Length; i++)
{
    arr3[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < arr3.Length; i++)
{
    sum += arr3[i];

}
Console.WriteLine(sum);

//manfiy sonlar sonini topish 

int[] arr11 = { -3, 4, -1, 0, -9 }
;

int count = 0;

for (int i = 0; i < arr11.Length; i++)
{
    if (arr11[i] < 0)
    {
        count++;
    }
}

Console.WriteLine("Manfiy sonlar soni: " + count);


int[] arr5 = new int[5];

for (int i = 0; i < arr5.Length; i++)
{
    arr5[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = arr5.Length - 1; i >= 0; i--)
{

    Console.WriteLine(arr5[i]);
}

//Massivda necha xil turdagi son bor (unique)
int[] arr6 = { 1, 2, 2, 3, 3, 4 }
;

int count1 = 0;

for (int i = 0; i < arr6.Length; i++)
{
    bool bor = false;

    for (int j = 0; j < i; j++)
    {
        if (arr6[i] == arr6[j])
        {
            bor = true;
            break;
        }
    }

    if (!bor)
    {
        count1++;
    }
}

//Console.WriteLine("Turli sonlar soni: " + count);

// 2 ta massivni birlashtirish
int[] a1 = { 1, 2, 3 };
int[] b = { 4, 5, 6 };

int[] c = new int[a1.Length + b.Length];

for (int i = 0; i < a1.Length; i++)
    c[i] = a1[i];

for (int i = 0; i < b.Length; i++)
    c[a1.Length + i] = b[i];

Console.WriteLine("Yangi massiv:");
foreach (int x in c)
{
    Console.WriteLine(x);
}

// Massivni saralash (sort)

int[] arr7 = { 5, 2, 9, 1 };

for (int i = 0; i < arr7.Length; i++)
{
    for (int j = i + 1; j < arr7.Length; j++)
    {
        if (arr7[j] < arr7[i])
        {
            int t = arr7[i];
            arr7[i] = arr7[j];
            arr7[j] = t;
        }
    }
}

Console.WriteLine("Saralangan massiv:");
foreach (int x in arr7)
{
    Console.WriteLine(x);
}
