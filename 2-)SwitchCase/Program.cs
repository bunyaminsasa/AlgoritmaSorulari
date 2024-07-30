#region Soru1

//  İki tam sayının modunu hesaplayan bir program yazın. Kullanıcıdan iki sayı girmesini isteyin ve sonucu ekrana yazdırın.

Console.WriteLine("Bir Sayi Giriniz");
int sayi = int.Parse(Console.ReadLine());

switch (Math.Sign(sayi))
{
    case -1:
        Console.WriteLine("Sayi Negatif");
        break;
    case 0:
        Console.WriteLine("Sayi Nötr");
        break;
    case 1:
        Console.WriteLine("Sayi Pozitif");
        break;

    default:
        Console.WriteLine("Lütfen Bir Sayi Giriniz...");
        break;
}

#endregion


#region Soru2

// Bugün, haftanı hangi günü ise switch case kullanarak ekrana yazdıralım...

string gun = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Monday => "Pazartesi",
    DayOfWeek.Tuesday => "Salı",
    DayOfWeek.Wednesday => "Çarşamba",
    DayOfWeek.Thursday => "Perşembe",
    DayOfWeek.Friday => "Cuma",
    DayOfWeek.Saturday => "Cumartesi",
    DayOfWeek.Sunday => "Pazar",
};

Console.WriteLine(gun);
#endregion


#region Soru3

// Kullanıcıdan bir harf (A-Z) veya rakam (0-9) girişi alan ve bu girişin harf mi yoksa rakam mı olduğunu belirleyen bir program yazınız.


Console.WriteLine("Bir metin Giriniz");
char girilenDeger = char.Parse(Console.ReadLine());

switch (char.ToLower(girilenDeger))
{
    case >= 'a' and <= 'z':
        Console.WriteLine($"Girilen Deger ({girilenDeger}), bir harf...");
        break;

    case <= '9' and >= '1':
        Console.WriteLine($"Girilen Deger ({girilenDeger}), bir sayi...");
        break;

    default:
        Console.WriteLine($"Girilen Deger ({girilenDeger}), uygun formatta değil...");
        break;
}

#endregion


#region Soru4

//  Kullanıcı tarafından girilen bir mevsimin hangi ay aralığında olduğunu gösteren bir program yazınız (örneğin, "Mart", "Nisan", "Mayıs" için "İlkbahar").

Console.WriteLine("Bir ay giriniz:");
string ay = Console.ReadLine().ToLower();

switch (ay)
{
    case "mart":
    case "nisan":
    case "mayıs":
        Console.WriteLine("İlkbahar mevsimi.");
        break;
    case "haziran":
    case "temmuz":
    case "ağustos":
        Console.WriteLine("Yaz mevsimi.");
        break;
    case "eylül":
    case "ekim":
    case "kasım":
        Console.WriteLine("Sonbahar mevsimi.");
        break;
    case "aralık":
    case "ocak":
    case "şubat":
        Console.WriteLine("Kış mevsimi.");
        break;
    default:
        Console.WriteLine("Geçersiz ay girişi.");
        break;
}



#endregion


#region Soru5

// Kullanıcıdan alınan bir ay numarasına (1-12) göre mevsim adını yazdıran bir program yazınız.

Console.WriteLine("Bir ay numarası giriniz (1-12):");
int ayNo = Convert.ToInt32(Console.ReadLine());

switch (ayNo)
{
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    default:
        Console.WriteLine("Geçersiz ay numarası.");
        break;
}


#endregion


#region Soru6

// Kullanıcıdan alınan bir notun harf karşılığını veren bir program yazınız (A-F arası). 90 ve üzeri A, 80-89 arası B, 70-79 arası C, 60-69 arası D, 0-59 arası F.

Console.WriteLine("Bir not giriniz");
int not = int.Parse(Console.ReadLine());

char harfNotu;

switch (not / 10)
{
    case 10:
    case 9:
        harfNotu = 'A';
        break;
    case 8:
        harfNotu = 'B';
        break;
    case 7:
        harfNotu = 'C';
        break;
    case 6:
        harfNotu = 'D';
        break;
    default:
        harfNotu = 'F';
        break;

}
Console.WriteLine($"Harf Notunuz...: {harfNotu}");

#endregion


#region Soru6

// Kullanıcıdan alınan bir karakterin (harf veya rakam) ASCII değerini gösteren bir program yazınız.

Console.WriteLine("Bir karakter giriniz:");
char karakter = Convert.ToChar(Console.ReadLine());

int asciiDeger;

switch (karakter)
{
    default:
        asciiDeger = (int)karakter;
        break;
}

Console.WriteLine($"ASCII değeri: {asciiDeger}");

#endregion
