#region Soru1

// Bir dizi oluşturun ve elemanlarını ekrana yazdırın.

int[] dizi = new[] { 1, 2, 3, 4, 5, 6 };

foreach (int item in dizi)
{
    Console.WriteLine(item);
}

#endregion


#region Soru2

// Bir dizideki en büyük ve en küçük elemanları bulunuz...

int[] dizi = new[] { 129, 14, 489, 99, 66, 33 };

int maxDeger = dizi[0];
int minDeger = dizi[0];

foreach (int item in dizi)
{
    if (item > maxDeger)
        maxDeger = item;

    else if (item < minDeger)
        minDeger = item;
}

Console.WriteLine($"En büyük Değer...: {maxDeger} En küçük değer...: {minDeger}");

#endregion


#region Soru3

// Bir dizinin elemanlarını tersine çevirin.

int[] dizi = new[] { 129, 14, 489, 99 };

Array.Reverse(dizi);

foreach (int item in dizi)
{
    Console.WriteLine(item);
}

#endregion


#region Soru4

// Bir dizinin elamanlarının toplamını ekrana yazdırın...

int[] dizi = new[] { 129, 14, 489, 99 };

int toplam = 0;

foreach (int item in dizi)
{
    toplam += item;
}
Console.WriteLine(toplam);

#endregion


#region Soru5

// Dışardan girilen bir ismin, elimizdeki dizide olup olmadığını kontrol edin.

Console.WriteLine("Bir isim giriniz...");
string isim = Console.ReadLine();

Array isimler = new[] { "Bünyamin", "Fatih", "Yalçın", "Hatice", "Yusuf" };
int sonuc = Array.IndexOf(isimler, isim);

Console.WriteLine(sonuc);


#endregion


#region Soru6

// Bir dizideki çift ve tek sayıların toplamını ayrı ayrı hesaplayın.


int[] dizi = new[] { 129, 14, 489, 99, 66 };

int tekToplam = 0;
int ciftToplam = 0;

foreach (int item in dizi)
{
    //1.Çözüün

    switch (item % 2)
    {
        case 0:
            ciftToplam += item;
            break;

        case 1:
            tekToplam += item;
            break;
    }

    //2 Çözüm

    if (item % 2 == 0)
        ciftToplam += item;

    else if (item % 2 == 1)
        tekToplam += item;
}

Console.WriteLine($"Cift Sayi Toplam... : {ciftToplam} Tek sayi Toplam... : {tekToplam}");

#endregion


#region Soru7

// Bir diziyi küçükten büyüğe sıralayın.


int[] dizi = new[] { 129, 14, 489, 99, 66 };

Array.Sort(dizi);

Console.WriteLine("Foreach Kullanımı");
foreach (int item in dizi)
{
    Console.WriteLine(item);
}

Console.WriteLine("For Kullanımı");
for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi.GetValue(i));
}


#endregion


#region Soru8


// İki diziyi birleştirip tek bir dizi oluşturun.


int[] dizi1 = new[] { 129, 14, 489 };
int[] dizi2 = new[] { 33, 66, 99 };

int[] yeniDizi = new int[dizi1.Length + dizi2.Length];

//Not: dizi1'in 0. ındexinden başla, YeniDizi'nin 0.indexine at ve dizi1'in llenght'i kadar...
Array.Copy(dizi1, 0, yeniDizi, 0, dizi1.Length);

//Not: dizi2'in 0. ındexinden başla, YeniDizi'nin dizi1.'ci  ndexine at ve dizi2'in llenght'i kadar...
Array.Copy(dizi2, 0, yeniDizi, dizi1.Length, dizi2.Length);

foreach (int item in yeniDizi)
{
    Console.WriteLine(item);
}


#endregion


#region Soru9

// Bir dizi oluşturun ve dizideki tüm çift sayıları ayrı bir diziye kopyalayan bir program yazın.


int[] dizi = new[] { 129, 14, 489, 33, 66, 99 };

// Not: dizi içerisindeki çift sayıları getir...
int[] ciftDizi = Array.FindAll(dizi, i => i % 2 == 0);

Console.WriteLine("Çift sayılar:");
foreach (int item in ciftDizi)
{
    Console.WriteLine(item);
}

#endregion


#region Soru10

// Bir dizi oluşturun ve dizinin elemanlarını çift ve tek sayı olarak iki ayrı diziye ayıran bir program yazın.

int[] dizi = new[] { 129, 14, 489, 99, 66 };

int[] ciftDizi = Array.FindAll(dizi, i => i % 2 == 0); // Bütün hepsi içinden çiftleri getir
int[] tekDizi = Array.FindAll(dizi, i => i % 2 == 1); // Bütün hepsi içinden tekleri getir


Console.WriteLine("Çift sayılar:");
foreach (int cift in ciftDizi)
{
    Console.WriteLine(cift);
}

Console.WriteLine("Tek sayılar:");
foreach (int tek in tekDizi)
{
    Console.WriteLine(tek);
}


#endregion


#region Soru11

// Bir dizi oluşturun ve bu dizideki tüm elemanların karesini alarak yeni bir diziye kopyalayan bir program yazın.

int[] dizi = new[] { 1, 2, 3, 4, 5 };

int[] yeniDizi = new int[dizi.Length];

for (int i = 0; i < dizi.Length; i++)
{
    yeniDizi[i] = dizi[i] * dizi[i];
}

Console.WriteLine("Elemanların kareleri:");
foreach (int kare in yeniDizi)
{
    Console.WriteLine(kare);
}

#endregion


#region Soru12

// Bir dizi oluşturun ve dizideki pozitif ve negatif elemanları ayrı dizilere ayıran bir program yazın.

int[] sayilar = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

int[] pozitifSayilar = Array.FindAll(sayilar, i => i > 0);
int[] negatifSayilar = Array.FindAll(sayilar, i => i < 0);

Console.WriteLine("Pozitif sayılar:");
foreach (int pozitif in pozitifSayilar)
{
    Console.WriteLine(pozitif);
}

Console.WriteLine("Negatif sayılar:");
foreach (int negatif in negatifSayilar)
{
    Console.WriteLine(negatif);
}

#endregion

