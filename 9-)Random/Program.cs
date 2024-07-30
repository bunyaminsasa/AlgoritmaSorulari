
#region Soru1

// 0 ile 100 arasında rastgele bir tamsayı üretin ve bu sayının çift mi, tek mi olduğunu kontrol edin ve ekrana yazdırın.

Random random = new Random();

int sayi = random.Next(100);

Console.WriteLine(sayi % 2 == 0 ? "Çift sayi geldi..." + sayi : "Tek sayi geldi..." + sayi);

#endregion


#region Soru2

// Bir zar atışı simüle ederek 1 ile 6 arasında rastgele bir sayı üretip ekrana yazdıralım...

Random random1 = new Random();
Random random2 = new Random();

Console.WriteLine($"Birinci zar...: {random1.Next(1, 6)}");
Console.WriteLine($"İkinci zar...: {random2.Next(1, 6)}");


#endregion


#region Soru3

// Bir diziden random (rastgele) 5 elamınını seçip yazdıralım...

int[] dizi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Random random = new Random();

for (int i = 0; i < 5; i++)
{

    Console.WriteLine(random.Next(dizi.Length));
}

#endregion


#region Soru4

// 0 ile 1 arasında rastgele ondalıklı (double) bir sayı üretin ve bu sayının bir dairenin içine mi, yoksa dışına mı düştüğünü kontrol edin.
Not: sayıların karelerinin toplamı 1'den küçük veya eşit ise nokta dairenin içindedir.

Random random = new Random();

double x = random.NextDouble();
double y = random.NextDouble();

bool sonuc = (x * x + y * y) <= 1;

Console.WriteLine(sonuc == true ? "Dairenin içine düşer..." : "Dairenin dışına düşer...");

#endregion


#region Soru5


// Bir zar simülasyonu yaparak 1'den 6'ya kadar rastgele bir sayı üretin ve bu işlemi 100 defa tekrarlayarak sonuçları bir diziye kaydedin.

Random random = new Random();
int[] dizi = new int[6];

for (int i = 0; i < 100; i++)
{
    int zarDegeri = random.Next(1, 7);

    dizi[zarDegeri - 1]++;
}

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine($"Zar {i + 1}: {dizi[i]} defa var");
}

#endregion

