
#region Soru1

// İki Tarih Arasındaki kaç gün ve kaç saat fark olduğunu hesaplayalım...

DateTime tarih1 = new DateTime(2024, 10, 7);
DateTime tarih2 = new DateTime(2024, 5, 3);

TimeSpan tarihFarkı = tarih1 - tarih2; // TimeSpan tarih farkı almamızı sağlar.

Console.WriteLine(tarihFarkı.TotalDays); // İki tarih arasında kaç gün var
Console.WriteLine(tarihFarkı.TotalHours); // İki tarih arasında saat var


#endregion


#region Soru2

// Belirli bir tarihe sırasıyla yıl, ay ve gün ekleyelim...

DateTime tarih =  DateTime.Now;

Console.WriteLine(tarih.AddYears(3)); // 3 yıl ekle
Console.WriteLine(tarih.AddMonths(8)); // 8 ay ekle
Console.WriteLine(tarih.AddDays(10)); // 10 gün ekle

#endregion


#region Soru3

// Belirli bir tarihin haftanın hangi günü olduğunu bulalım...

DateTime tarih = new DateTime(2024, 7, 10);
Console.WriteLine($"Bugün günlerden {tarih.DayOfWeek}");

#endregion


#region Soru4


// UTC(Evrensel Zaman) ve yerel zaman dilimi arasındaki farkı hesaplayalım

DateTime yerelTarih = DateTime.Now;

DateTime evrenselTarih = yerelTarih.ToUniversalTime();

TimeSpan tarihFarkı = yerelTarih - evrenselTarih;

Console.WriteLine(tarihFarkı);


#endregion


#region Soru5

// Belirli bir tarihin ayın kaçıncı günü olduğunu bulalım...

DateTime tarih = new DateTime(2024, 7, 10);

int tarihGunu = tarih.Day;

Console.WriteLine($"Ayın {tarihGunu}. Günü");


#endregion


#region Soru6

// Belrili bir tarihin ait olduğu haftanın başlangıç ve bitiş tarihlerini bulalım...

DateTime tarih = new DateTime(2024, 7, 10);

DayOfWeek haftanınGunu = tarih.DayOfWeek; // Haftanın hangi gününde olduğumuzu bulduk: Çarşamba...

int gun = (int)haftanınGunu; // Bulduğumuuz günün sayısal değerini yani kaçıncı gün olduğunu hesapladık: 3 Gün

DateTime ilkGun = tarih.AddDays(-gun + 1); // İçinde bulunduğumuz günün, sayısal değerini çıkardığımızda hafta başını elde ederiz. +1 Ekledik çünkü içinde bulunduğumuz gün, bitmiş olarak kabul edilmiyor...

DateTime sonGun = ilkGun.AddDays(6); // Haftanın başına 6 gün eklersek de son günü bulmuş oluruz...


Console.WriteLine($"Haftanın İlk Günü...: {ilkGun.DayOfWeek}");
Console.WriteLine($"Haftanın Son Günü...: {sonGun.DayOfWeek}");

#endregion


#region Soru7

// İki tarih arasındaki iş günlerinin (Pazartesi - Cuma) toplamını hesaplayalım...

DateTime baslangıcTarihi = new DateTime(2024, 5, 3);
DateTime bitisTarihi = new DateTime(2024, 10, 17);

int isGunuToplam = 0;

for (DateTime date = baslangıcTarihi; date <= bitisTarihi; date = date.AddDays(1))
{
    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
    {
        isGunuToplam++;
    }
}

Console.WriteLine("İş Günleri Sayısı: " + isGunuToplam);

#endregion




