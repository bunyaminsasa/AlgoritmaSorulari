
#region Soru1

// Kullanıcıdan alınan iki sayının toplamını hesaplarken meydana gelebilecek hataları yakalayın ve uygun bir hata mesajı görüntüleyin.

try
{
    Console.WriteLine("Birinci sayiyi giriniz...");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("İkinci sayiyi giriniz...");
int sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Toplam... : {sayi1 + sayi2}");
}
catch (Exception hataMesajı)
{
    Console.WriteLine($"Lütfen bir sayi girinizi... : {hataMesajı}");

}

#endregion


#region Soru2

// Bir dizinin geçersiz bir indeksine erişmeye çalışırken meydana gelebilecek bir hatayı yakalayın ve uygun bir hata mesajı görüntüleyin.

try
{
    int[] numbers = { 1, 2, 3 };
int deger = numbers[5];
Console.WriteLine("Değer: " + deger);
}
catch (Exception hataMesajı)
{
    Console.WriteLine($"Hata: Geçersiz dizi indeksi...: {hataMesajı}");
}



#endregion


#region Soru3

// Var olmayan bir dosyayı okumaya çalışırken meydana gelebilecek bir hatayı yakalayın ve uygun bir hata mesajı görüntüleyin.

try
{
    string dosya = File.ReadAllText("olmayan_dosya.txt");
Console.WriteLine("Dosya içeriği: " + dosya);
}
catch (Exception hataMesajı)
{
    Console.WriteLine($"Dosya Hatası!..: {hataMesajı}");
}


#endregion

