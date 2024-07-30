// ARRAY - SETVALUE / GETVALUE

#region Soru1

// Bir 3 elamanlı int dizisi oluşturun ve bu dizinin elemanlarını SetValue ile atayın, GetValue ile okuyun...

Array sayilar = new int[3];

sayilar.SetValue(129, 0);
sayilar.SetValue(140, 1);
sayilar.SetValue(489, 2);

for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine((int)sayilar.GetValue(i));
}

#endregion


#region Soru2

// Bir int dizisi oluşturun ve bu dizinin her bir elemanına 0'dan 9'a kadar olan sayıları atayın. Daha sonra dizinin tüm elemanlarını GetValue methodu kullanarak ekrana yazdırın.

Array dizi = new int[10];


for (int i = 0; i < dizi.Length; i++)
{
    dizi.SetValue(i, i);
}

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine((int)dizi.GetValue(i));
}

#endregion


#region Soru3

// 3 elemanlı bir string dizisi oluşturun ve bu dizinin elemanlarına kullanıcıdan aldığınız isimleri SetValue methodu ile atayın. Ardından, dizideki isimlerden belirli bir ismi arayıp GetValue methodu ile bulun ve ekrana yazdırın. Bulamazsanız "İsim bulunamadı" mesajı yazdırın.


Array isimler = new string[3];

for (int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine($"Lütfen {i}. ismi giriniz");
    string isim = Console.ReadLine();

    isimler.SetValue(isim, i);
}

Console.WriteLine("");
Console.WriteLine("Bütün İsimler Getirildi...:");
Console.WriteLine("");
for (int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine((string)isimler.GetValue(i));
}

Console.WriteLine("");

Console.WriteLine("Lütfen aradığınız ismi giriniz...:");
string arananIsim = Console.ReadLine();
bool bulundu = false;

for (int i = 0; i < isimler.Length; i++)
{
    if ((string)isimler.GetValue(i) == arananIsim)
    {
        Console.WriteLine($"{arananIsim} İsmi bulundu...");
        bulundu = true;
        break;
    }
}

if (!bulundu)
{
    Console.WriteLine($"{arananIsim} İsmi bulunamadı");
}

#endregion


#region Soru4

// 10 elamanlı bir int dizisi oluşturun ve dizinin elemanlarına 0-100 aralığında rastgele sayılar atayın. Bu sayıları GetValue methodu kullanarak toplayın ve ortalamalarını hesaplayarak ekrana yazdırın.

Array randomDizi = new int[10];

Random random = new Random();

for (int i = 0; i < randomDizi.Length; i++)
{
    randomDizi.SetValue(random.Next(100), i);
}

double toplam = 0;

for (int i = 0; i < randomDizi.Length; i++)
{
    toplam += (int)randomDizi.GetValue(i);
}

Console.WriteLine($"Rastgele sayiların ortalaması... {toplam / randomDizi.Length}");

#endregion


#region Soru5

// 26 elamanlı(alfabe sayısı) bir char dizisi oluşturun ve bu dizinin elemanlarına SetValue methodu ile 'A' ile 'Z' arasındaki karakterleri atayın. Dizideki bu karakterleri ters sırada GetValue methodu kullanarak ekrana yazdırın.


Array charDizi = new char[26];

for (int i = 0; i < charDizi.Length; i++)
{
    charDizi.SetValue((char)('A' + i), i);
}

Array.Reverse(charDizi);

for (int i = 0; i < charDizi.Length; i++)
{
    Console.WriteLine(charDizi.GetValue(i));
}


#endregion




// ARRAY - CLEAR

#region Soru6

// Bir int dizisi oluşturun ve bu dizinin tüm elemanlarını Array.Clear methodunu kullanarak dizinin tüm elemanlarını sıfırlayın.

int[] dizi = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Array.Clear(dizi);

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi.GetValue(i));
}

#endregion


#region Soru7

// Bir string dizisi içine meyve isimlerini girin, sonra da Array.Clear ile dizinin belli aralıktaki değerlerini default haline getirin...

string[] meyveler = new[] { "karpuz", "kavun", "çilek", "muz", "kiraz", "erik" };

Array.Clear(meyveler, 2, 3);

for (int i = 0; i < meyveler.Length; i++)
{
    Console.WriteLine(meyveler.GetValue(i));
}


#endregion


#region Soru8

// 6 elemanlı bir string dizisi oluşturun ve dizinin elemanlarını kullanıcıdan aldığınız isimlerle doldurun. Ardından dizinin ilk yarısını Array.Clear methodunu kullanarak temizleyin ve dizinin tüm elemanlarını ekrana yazdırın.

string[] dizi = new string[6];

for (int i = 0; i < dizi.Length; i++)
{
    Console.Write("Lütfen bir isim giriniz...: ");
    dizi[i] = Console.ReadLine();
}

Array.Clear(dizi, 0, dizi.Length / 2);

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi.GetValue(i));
}

#endregion


#region Soru9

// 10 elemanlı bir double dizisi oluşturun ve dizinin elemanlarını rastgele sayılarla doldurun. Dizinin son çeyreğini Array.Clear methodunu kullanarak temizleyin ve dizinin tüm elemanlarını ekrana yazdırın.

double[] dizi = new double[10];

Random random = new Random();

for (int i = 0; i < dizi.Length; i++)
{
    dizi.SetValue((double)random.NextDouble() * 100, i);
}

Array.Clear(dizi, dizi.Length * 3 / 4, dizi.Length / 4);

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi.GetValue(i));
}

#endregion




// ARRAY - COPY

#region Soru10

// Bir int dizisi oluşturun ve bu dizinin tüm elemanlarını Array.Copy methodunu kullanarak başka bir diziye kopyalayın.

int[] dizi1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] dizi2 = new int[dizi1.Length];

Array.Copy(dizi1, dizi2, dizi1.Length);


for (int i = 0; i < dizi2.Length; i++)
{
    Console.WriteLine(dizi2.GetValue(i));
}

#endregion


#region Soru11

// Bir int dizisi oluşturun ve bu dizinin elemanlarının yarısını Array.Copy methodunu kullanarak başka bir diziye kopyalayın.

int[] dizi1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] dizi2 = new int[dizi1.Length / 2];

Array.Copy(dizi1, dizi2, dizi1.Length / 2);


for (int i = 0; i < dizi2.Length; i++)
{
    Console.WriteLine(dizi2.GetValue(i));
}

#endregion


#region Soru12

// Kullanıcıdan 5 adet meyve ismi alınız, alın ve bu isimleri bir diziye atayın, sonra da elde edilen diziyi ters çevirerk kopyalayın.

string[] meyveler = new string[5];
string[] yeniMeyveler = new string[meyveler.Length];


for (int i = 0; i < meyveler.Length; i++)
{
    Console.Write("Lütfen bir meyve ismi giriniz...: ");
    meyveler[i] = Console.ReadLine();
}

Array.Reverse(meyveler);
Array.Copy(meyveler, yeniMeyveler, meyveler.Length);

Console.WriteLine("");
Console.WriteLine("Tersten Sıralanıp Kopyalanmış Hali...:");
for (int i = 0; i < yeniMeyveler.Length; i++)
{
    Console.WriteLine(yeniMeyveler.GetValue(i));
}

#endregion




// ArraySegment

#region Soru13

// Bir int dizisini kullanarak bir ArraySegment oluşturun, bu segment, dizinin 2. indeksinden başlasın ve 3 eleman içersin ve bu segmenti ekrana yazdırın:

int[] sayilar = { 1, 2, 3, 4, 5 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 2, 3);

// For ile yazdırma
for (int i = 0; i < segment.Count; i++)
{
    Console.WriteLine(segment[i]);
}

Console.WriteLine(" ");
// Foreach ile yazdırma
foreach (var item in segment)
{
    Console.WriteLine(item);
}


#endregion


#region Soru14

// Bir int dizisini kullanarak bir ArraySegment oluşturun, bu segment, dizinin 3. indeksinden başlasın ve 5 eleman içersin ve bu segmenti yeni bir diziye kopyalayıp ekrana yazdırın:


int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 3, 5);

int[] dizi = new int[segment.Count]; // Segment'in index sayısı kadar yeni bir dizi oluşturduk.

segment.CopyTo(dizi); // Segment'in değerlerini oluşturduğumuz diziye kopyaladık.

foreach (var item in dizi)
{
    Console.WriteLine(item);
}

#endregion


#region Soru15


// Bir string dizisini kullanarak bir ArraySegment oluşturun, bu segment, dizinin 2. indeksinden başlasın ve 3 eleman içersin ve bu segment içerisindeki bir elemanı değiştirin. Sonra da orijinal diziyi ekrana yazdırın:

string[] meyveler = new[] { "karpuz", "kavun", "çilek", "muz", "kiraz", "erik" };

ArraySegment<string> segment = new ArraySegment<string>(meyveler, 2, 3);

segment[1] = "şeftali"; // Segment'in 1. indexli elamnının değerini değiştirdik.


foreach (var item in meyveler)
{
    Console.WriteLine(item);
}


#endregion


#region Soru16

// Bir int dizisini kullanarak bir ArraySegment oluşturun, segment, 3. indexten başlayıp 4 elemanlı olsun ve IsEmpty özelliğiyle bu segmenti kontrol edin. 

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 3, 4);

bool isEmpty = segment.Count > 0;

Console.WriteLine("Segment sayısı 0'dan büyük...");


#endregion


#region Soru17


// Bir int dizisini kullanarak bir ArraySegment oluşturun, segment, 3. indexten başlayıp 4 elemanlı olsun ve bu segmenti ToArray metodu ile yeni bir diziye dönüştürün. Yeni diziyi ekrana yazdırın:

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 3, 4);

int[] dizi = segment.ToArray(); // İlgili segmenti, ToArray metodu ile yeni bir diziye atadık.

foreach (var item in dizi)
{
    Console.WriteLine(item);
}


#endregion


#region Soru18

// Bir int dizisinden iki farklı ArraySegment oluşturun ve bu segmentlerin birleşimini yeni bir dizi olarak ekrana yazdırın:

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment1 = new ArraySegment<int>(sayilar, 0, 5);
ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 5, 5);

int[] yeniDizi = new int[segment1.Count + segment2.Count];

segment1.CopyTo(yeniDizi, 0); // segment1'i, yeniDizi'nin içine 0. indexten başlatarak atadık.
segment2.CopyTo(yeniDizi, segment1.Count()); // segment''yi, yeniDizi'nin içine egment1'in count'u kadar olan indexten başlatarak atadık.

foreach (var item in yeniDizi)
{
    Console.WriteLine(item);
}

#endregion


#region Soru19

// Bir int dizisiyle bir ArraySegment oluşturun, bu segment dizinin 3. indeksinden başlasın ve 6 eleman içersin ve bu segmentin çift sayılarını toplayarak ekrana yazdırın.

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 3, 6);

int toplam = segment.Where(w => w % 2 == 0).Sum(); // İlgili segmentin çift sayılarını elde edip topladık.

Console.WriteLine(toplam);


#endregion


#region Soru20

// Bir int dizisiyle bir ArraySegment oluşturun, bu segment dizinin 3. indeksinden başlasın ve 6 eleman içersin ve bu segmentin sonuna yeni değer ekleyip ekrana yazdırın...

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar, 3, 6);

int[] yeniDizi = new int[segment.Count + 1]; // Sonuna +1 eklememizin sebebi, sonradan bu diziye 1 elaman daha ekleyeceğimiz için...

segment.CopyTo(yeniDizi, 0); // İlgili segment'i yeni dizi kopyaladık...

yeniDizi[yeniDizi.Length - 1] = 129; // Yeni dizinin son elemanına değer atadık.

foreach (var item in yeniDizi)
{
    Console.WriteLine(item);
}


#endregion


#region Soru21


// Bir int dizisiyle bir ArraySegment oluşturun, bu segmentten bir alt segment daha oluşturun. Bu alt segment, üst segmentin indexinin yarısından başlayarak 7 elaman içersin. Sonra da bu alt segmentin tek sayılarını ve cift sayılarını yeni bir diziye atayın ve ekrana yazdırın...

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

ArraySegment<int> ustSegment = new ArraySegment<int>(sayilar);

ArraySegment<int> altSegment = new ArraySegment<int>(ustSegment.Array, ustSegment.Count / 2, 7);


int[] tekDizi = new int[altSegment.Where(w => w % 2 == 1).Count()]; // Tek sayıların countunu aldık.
int tekSayilar = 0;

int[] ciftDizi = new int[altSegment.Where(w => w % 2 == 0).Count()]; // Çift sayıların countunu aldık.
int ciftSayilar = 0;


foreach (var sayi in altSegment)
{
    if (sayi % 2 == 1) // Tek sayıları, tekDizi'nin içerisinw atadık.
        tekDizi[tekSayilar++] = sayi;

    else if (sayi % 2 == 0) // Çift sayıları, tekDizi'nin içerisinw atadık.
        ciftDizi[ciftSayilar++] = sayi;
}

Console.WriteLine("Çift Sayilar");
foreach (var item in ciftDizi)
{
    Console.WriteLine(item);
}

Console.WriteLine("");

Console.WriteLine("Tek Sayilar");
foreach (var item in tekDizi)
{
    Console.WriteLine(item);
}

#endregion




// StringSegment

using Microsoft.Extensions.Primitives;
using System;
using System.Collections;

#region Soru22

 // Bir StringSegment kullanarak bir string'in ilk 5 karakterini elde edelim hem kendisini hem de uzunluğunu yazdıralım

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 0, 5);

Console.WriteLine($"Elde edilen Kısım...: {segment}, Uzunluğu...: {segment.Length}");

#endregion


#region Soru23


// Bir StringSegment ile orijinal string'in belirli bir kısmını karşılaştırarak, eşleşip eşleşmediğini nasıl kontrol edersiniz? Örneğin, "Hello, World!" string'inin ilk 5 karakterinin "Hello" ile eşleşip eşleşmediğini kontrol edin.

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 0, 5);

Console.WriteLine(segment.Equals("Bünyamin")); // Segment ile asıl metnin belirli bir yerini karşılaştırdık.


#endregion


#region Soru24

// Bir StringSegment kullanarak bir string'in belirli bir kısmını tersine çevirelim...

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 4, 10);

char[] charArray = segment.ToString().ToCharArray(); // Elde ettiğmiz segmenti, Char Array yaptık.

Array.Reverse(charArray); // Char Array'i tersine çevirdik...

Console.WriteLine(new string(charArray)); // Char Array'i tekrar string'e dönüştürdük.


#endregion


#region Soru25

// Bir StringSegment kullanarak bir string'in belirli bir kısmını büyük harfe çevirin.

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 4, 10);

Console.WriteLine(segment.ToString().ToUpper()); // Elde ettimiz segment'in hepsini büyük yaptık.


#endregion


#region Soru26

// Bir StringSegment'in içindeki belirli bir karakterin sayısını bulun. Örneğin, "Hello, World!" string'inin "World" kısmında 'o' harfinin kaç kez geçtiğini bulun.

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 2, 25);

int sayi = 0;

for (int i = 0; i < segment.Length; i++)
{
    if (segment[i] == 'a')
        sayi++;
}
Console.WriteLine($"Elde edilen Segment...: {segment}");
Console.WriteLine($"Segment içerisinde {sayi} tane 'a' var...");



#endregion


#region Soru27

// Bir StringSegment kullanarak bir string'in belirli bir kısmını başka bir string ile değiştirin. Örneğin, "Hello, World!" string'inin "World" kısmını "Universe" ile değiştirin.

string metin = "Bünyamin SASA Software Developer";

StringSegment segment = new StringSegment(metin, 2, 10);

string yeniMetin = metin.Replace(segment.ToString(), " Bunu yeni ekledim "); // 1. Çözüm
Console.WriteLine(yeniMetin);

string yeniMetin = metin.Remove(segment.Offset, segment.Length).Insert(segment.Offset, "Yeni Deger");
Console.WriteLine(yeniMetin); // 2. Çözüm

#endregion



// ArrayList

#region Soru28


// Bir ArrayList oluşturup içine meyveler ekleyip ekrana yazdıralım

ArrayList meyveler = new ArrayList { };

meyveler.Add("elma");
meyveler.Add("portakal");
meyveler.Add("muz");

foreach (var item in meyveler)
{
    Console.WriteLine(item);
}


#endregion


#region Soru29

// Bir ArrayList oluşturun ve içine sayılar ekleyin. Sonra da herhangi bir index değerini silin...

ArrayList sayilar = new ArrayList { };

sayilar.Add(129);
sayilar.Add(140);
sayilar.Add(489);
sayilar.Add(99);
sayilar.Add(66);
sayilar.Add(33);

sayilar.RemoveAt(5); // 5. index'in değerini sil...


foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

#endregion


#region Soru30

// Bir ArrayList içindeki elemanları ters çevirip içindeki string elemanlarını ekrana yazdıralım... Ve bu elemanların içinde "Çilek" olup olmadığını kontrol edelim.

ArrayList meyveler = new ArrayList { };

meyveler.Add("elma");
meyveler.Add("portakal");
meyveler.Add("muz");
meyveler.Add(129);
meyveler.Add(14);
meyveler.Add(489);

meyveler.Reverse(); // Ters çevirdik...
bool durum = meyveler.Contains("çilek"); // Kontrol yaptık...

foreach (var item in meyveler)
{
    if (item is string)
        Console.WriteLine((string)item);
}

Console.WriteLine("");

if (durum)
    Console.WriteLine("Çilek Var");
else Console.WriteLine("Çilek yok");

#endregion

