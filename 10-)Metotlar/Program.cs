
#region Soru1

// Bir öğrencinin aldığı puanı giren ve bu puana göre öğrencinin notunu (A, B, C) döndüren bir metot yazın.

Console.Write("Lütfen bir not giriniz...:");
int girilenNot = int.Parse(Console.ReadLine());

string sonuc = NotHesapla(girilenNot);
Console.WriteLine(sonuc);


string NotHesapla(int not)
{
    if (not >= 85)
        return "Notunuz A";

    else if (not >= 50 && not < 85)
        return "Notunuz B";

    else
        return "Notunuz C";
}



#endregion


#region Soru2

// Dışardan girilen iki sayının toplamını döndüren metot yazın.

Console.WriteLine("Birinci Sayiyi Giriniz");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("İkinci Sayiyi Giriniz");
int sayi2 = int.Parse(Console.ReadLine());

int toplam = SayiTopla(sayi1, sayi2);
Console.WriteLine("Sonuc : " + toplam);


int SayiTopla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

#endregion


#region Soru3

// Bir dizideki en büyük sayıyı bulan bir metot yazın.

int[] sayilar = new int[] { 129, 140, 33, 48, 59, 61, 77, 489, 99, 100 };

int maxDeger = MaxDegerBul(sayilar);
Console.WriteLine("En büyük deger " + maxDeger);



int MaxDegerBul(int[] sayilar)
{
    int maxSayi = sayilar[0];

    foreach (int item in sayilar)
    {
        if (item > maxSayi)
            maxSayi = item;
    }

    return maxSayi;
}

#endregion


#region Soru4

// Bir metin içindeki harf ve kelime sayısını bulan metotları yazın

string metin = "Bunyamin SASA Software Developer";

int harfToplamı = HarfToplam(metin);
Console.WriteLine("Toplam Harf : " + harfToplamı);


int kelimeToplamı = KelimeToplam(metin);
Console.WriteLine("Toplam Kelime : " + kelimeToplamı);

int HarfToplam(string metin)
{
    int harfSayisi = metin.Length;
    return harfSayisi;
}

int KelimeToplam(string metin)
{
    string[] kelimeSayisi = metin.Split(' ');
    return kelimeSayisi.Length;
}

#endregion


#region Soru5

// Verilen bir sayının faktöriyelini hesaplayan bir metot yazın...

Console.WriteLine("Bir Sayi Giriniz");
int sayi = int.Parse(Console.ReadLine());

int sonuc = FaktoriyelHesapla(sayi);
Console.WriteLine("Faktöriyel : " + sonuc);

int FaktoriyelHesapla(int sayi)
{
    if (sayi == 0)
        return 1;
    return sayi * FaktoriyelHesapla(sayi - 1);
}

#endregion


#region Soru6

// Bir dizi içerisindeki belirli bir elemanın kaç kez geçtiğini bulan bir metot yazın.

int[] sayilar = new int[] { 129, 140, 33, 48, 59, 129, 140, 489, 99, 129 };

Console.WriteLine("Bir Sayi Giriniz");
int girilenSayi = int.Parse(Console.ReadLine());

int toplam = ElemanSayisiHesapla(sayilar);
Console.WriteLine($"Girilen sayi toplam {toplam} defa bulundu...");

int ElemanSayisiHesapla(int[] sayilar)
{
    int elemanSayisi = 0;

    foreach (int item in sayilar)
    {
        if (item == girilenSayi)
            elemanSayisi++;

    }

    return elemanSayisi;

}

#endregion


#region Soru7

// Bir metin içerisinde kaç tane sesli harf olduğunu bulan metodu yazalım.

string metin = "Bunyamin SASA Software Developer";

int toplam = SesliHarfToplam(metin);
Console.WriteLine("Toplam sesli harf sayisi : " + toplam);

int SesliHarfToplam(string metin)
{
    int toplam = 0;

    string sesliHarf = "aeiouAEIOU";

    foreach (char i in metin)
    {
        if (sesliHarf.Contains(i))
            toplam++;
    }

    return toplam;
}

#endregion


#region Soru8


// Bir dizi içerisindeki elemenları küçükten büyüğe sıralayap yeni bir diziye atayan metodu yazalım

int[] sayilar = new int[] { 129, 140, 33, 48, 59, 61, 77, 489, 99, 100 };

int[] yeniDizi = Metot(sayilar); // Metodu çağırıp işledik...


for (int i = 0; i < yeniDizi.Length; i++)
{
    Console.WriteLine(yeniDizi.GetValue(i)); // Sırlanmış halini ekrana yazdırdık
}

int[] Metot(int[] sayilar)
{
    int[] yeniDizi = new int[sayilar.Length];

    Array.Sort(sayilar); // Küçükten büyüğe sıraladık

    for (int i = 0; i < sayilar.Length; i++)
    {
        yeniDizi[i] = sayilar[i]; // yeni diziye değer atması yaptık
    }

    return yeniDizi;
}

#endregion


#region Soru9


// Bir metnin her kelimesinin ilk harfini büyük yapan bir metot yazın.

string metin = "bunyamin sasa software developer";

string yeniMetin = Metot(metin); // Metodu Çağırıp uyguladık...
Console.WriteLine(yeniMetin);

string Metot(string metin)
{
    string[] kelimeler = metin.Split(' '); // Metni, kelimelere böldük...


    for (int i = 0; i < kelimeler.Length; i++)
    {
        if (kelimeler[i].Length > 0)
            kelimeler[i] = char.ToUpper(kelimeler[i][0]) + kelimeler[i].Substring(1); // Her kelimenin ilk harifini büyük yaptık...

    }

    return string.Join(" ", kelimeler); // Kelimelere bölünmüş metni, tekrar tek bir metin haline getirdik
}


#endregion


#region Soru10

// Verilen bir dizideki çift ve tek sayıların toplamını ayrı ayrı bulan bir metot yazın.

int[] sayilar = new int[] { 129, 140, 33, 48, 59, 61, 77, 489, 99, 100 };

(int tekSayiToplamı, int ciftSayiToplamı) = Hesapla(sayilar);

Console.WriteLine("Çift sayıların toplamı: " + ciftSayiToplamı);
Console.WriteLine("Tek sayıların toplamı: " + tekSayiToplamı);


(int, int) Hesapla(int[] sayilar)
{
    int tekSayiToplam = 0;
    int ciftSayiToplam = 0;

    foreach (int item in sayilar)
    {
        if (item % 2 == 0)
            ciftSayiToplam += item;
        else tekSayiToplam += item;
    }

    return (tekSayiToplam, ciftSayiToplam);
}

#endregion


#region Soru11

// Verilen bir metindeki kelimeleri alfabetik sıraya göre sıralayan bir metot yazın.

string metin = "Bunyamin SASA Software Developer";

string yeniMetin = KelimeSırala(metin); // Metotu çağırıp uyguladık...
Console.WriteLine("Alfabetik sıraya göre: " + yeniMetin);

string KelimeSırala(string metin)
{
    string[] kelimeler = metin.Split(' '); // Metni kelimelere ayırdık

    Array.Sort(kelimeler); // Kelimeleri sıraladık

    return string.Join(" ", kelimeler); // Kelimeleri sıralı şekilde birleştirdik
}

#endregion


#region Soru12

// Verilen bir tarihin hangi gün olduğunu döndüren bir metot yazın.

string Tarih(DateTime date)
{
    return date.DayOfWeek.ToString();
}

DateTime tarih = new DateTime(2024, 07, 23);

string gün = Tarih(tarih);

Console.WriteLine("Günün adı: " + gün);

#endregion


#region Soru13

// Verilen bir metin içindeki tüm rakamları bulan ve toplamını hesaplayan bir metot yazın.


int SayiBul(string metin)
{
    int toplam = 0;

for (int i = 0; i < metin.Length; i++) // for ile yapım
{
    if (char.IsDigit(metin[i])) // metnin i'nin indexindeki o char değer, bir sayısal ifademi?
        toplam += metin[i] - '0';
}

foreach (char item in metin) // foreach ile yapım
{
    if (char.IsDigit(item)) // metnin içindeki item değeri, sayisal bir char değer mi?
        toplam += item - '0';
}

return toplam;
}


string metin = "Bünyamin SASA 3 yıllık yazılımcı ve 25 yaşında, 40 yaş olgunluk yaşı derler.";
int sayilarınToplamı = SayiBul(metin);
Console.WriteLine(sayilarınToplamı);

#endregion


#region Soru14

// Bir string ifadenin içindeki kelimelerin tersten yazılmış halini döndüren bir metot yazın

string metin = "Bünyamin SASA Software Developer";

string tersMetin = KelimeleriTersYaz(metin);// Metodu çağırıp uyguladık
Console.WriteLine(tersMetin);


string KelimeleriTersYaz(string ifade)
{
    string[] kelimeler = metin.Split(' '); // Her kelimeyi tek tek yakaladık...

    for (int i = 0; i < kelimeler.Length; i++)
    {
        char[] harfler = kelimeler[i].ToCharArray(); // Her kelimenin her harflerini char dizisi olarak ayırdık...

        Array.Reverse(harfler); // Her kelimenin her harflerini ters çevirdik

        kelimeler[i] = new string(harfler); // Char dizisi olan harfleri, tekrar string hale getirdik
    }

    return string.Join(" ", kelimeler); // En son da kelimeleri joinleyip return ettik...
}


#endregion


#region Soru15


// Verilen bir string'de en çok tekrar eden karakteri bulan bir metot yazın.

string metin = "Bünyamin SASA Software Developer";

char sonuc = EnCokTekrarEdenKarakter(metin);
Console.WriteLine($"En Cok Tekrar Eden Karakter...: {sonuc}");


char EnCokTekrarEdenKarakter(string deger)
{

    Dictionary<char, int> karakterSayisi = new Dictionary<char, int>(); // Metin içerisindeki karakter sayılarını tespit etmek için Dictionary'i kullandık...

    foreach (char item in metin)
    {
        if (karakterSayisi.ContainsKey(item))
            karakterSayisi[item]++; // Tekrar eden harflerin toplam sayısını aldık...
        else
            karakterSayisi[item] = 1; // Her harften en bir tane var, o yüzden else durumdan 1 döndük...
    }


    char enCokTekrarEdenChar = ' ';
    int enYuksekSayi = 0;

    foreach (var item in karakterSayisi)
    {
        if (item.Value > enYuksekSayi)
        {
            enYuksekSayi = item.Value;
            enCokTekrarEdenChar = item.Key;
        }
    }

    return enCokTekrarEdenChar;

}

#endregion


#region Soru16

// Verilen bir dizideki pozitif ve negatif sayıların toplamını ayrı ayrı bulan bir metot yazın.

int[] sayilar = new int[] { -1, -2, 3, 4, 5, 6, 10, -7, -8, -4 };

(int pozitifToplam, int negatifToplam) = ToplamHesapla(sayilar); // Metodu çağırıp uyguladık
Console.WriteLine($"Pozitif Toplam : {pozitifToplam}");
Console.WriteLine($"Negatif Toplam : {negatifToplam}");



(int, int) ToplamHesapla(int[] dizi)
{
    int negatifTopla = 0;
    int pozitifTopla = 0;

    foreach (int item in dizi)
    {
        if (item > 0)
            pozitifTopla += item;
        else
            negatifTopla += item;
    }

    return (pozitifTopla, negatifTopla);
}

#endregion


#region Soru17

// Bir ürünün indirimli fiyatını hesaplayan bir metot yazın. İndirimin hesaplanması işlemini local function ile yapın...


double IndirimliFiyatHesapla(double orijinalFiyat, double indirimOrani)
{
    double IndirimHesapla(double fiyat, double oran)
    {
        return fiyat - (fiyat * oran / 100);
    }

    return IndirimHesapla(orijinalFiyat, indirimOrani);
}

double netFiyat = IndirimliFiyatHesapla(1000, 10);
Console.WriteLine(netFiyat);


#endregion


#region Soru18


// Bir metnin içindeki kelime sayısını bulan bir metot yazınız. Kelime sayısını hesaplama işlemini local function ile yapın...

int KelimeSayisiHesapla(string metin)
{
    int Hesapla(string metin)
    {
        return metin.Split(' ').Length;
    }

    return Hesapla(metin);
}

string cumle = "Bünyamin SASA Software Developer";
int sonuc = KelimeSayisiHesapla(cumle);
Console.WriteLine(sonuc);

#endregion





