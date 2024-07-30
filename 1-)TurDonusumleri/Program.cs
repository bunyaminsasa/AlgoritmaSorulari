#region Soru1

// Bir string türündeki sayıyı güvenli bir şekilde int türüne dönüştürün.

Console.WriteLine("Lütfen bir metin giriniz...:");
string metin = Console.ReadLine();


if (int.TryParse(metin, out int deger))
{
    Console.WriteLine("Metin değeri int'ye donebilir");
    deger = Convert.ToInt32(metin);
    Console.WriteLine($"Sonuc... : {deger}");
}

else
    Console.WriteLine("Metin değeri int'ye dönemez!");

#endregion

#region Soru2

// Soru: DateTime türünde bir değişkeni string türüne dönüştürün.

DateTime dateTime = DateTime.Now;
string donusumSonuc = dateTime.ToString();
Console.WriteLine(donusumSonuc);

#endregion

#region Soru3

// Bir string dizisindeki tüm sayısal değerleri int türüne dönüştürüp toplamasını yapın. 

string[] dizi = { "1", "3", "5" };

int sum = 0;

foreach (string sayi in dizi)
{
    sum += int.Parse(sayi);
}

Console.WriteLine(sum);

#endregion

#region Soru4

// Object türünde bir listede bulunan her bir öğeyi uygun türüne dönüştürüp toplamasını yapın (sayılar int veya double türünde olabilir).

List<object> objectList = new List<object> { 1, 3.14, "129", "14", 1.6 };

double topla = 0;

foreach (var item in objectList)
{
    if (item is int)
        topla += (int)item;

    else if (item is double)
        topla += (double)item;

    else if (item is string)
        topla += double.Parse((string)item);
}

Console.WriteLine(topla);


#endregion

#region Soru5

//  string türünde bir sayıyı önce double, sonra int, ardından string türüne dönüştürün ve her adımda çıktıyı yazdırın.

string stringSayi = "129,14";

double doubleSayi = Convert.ToDouble(stringSayi);
Console.WriteLine(doubleSayi);

int intSayi = (int)doubleSayi;
Console.WriteLine(intSayi);

string finalStringSayi = intSayi.ToString();
Console.WriteLine(finalStringSayi);

#endregion

#region Soru6

//  List<object> içindeki sayısal ve metinsel karışık öğeleri ayıklayarak ayrı ayrı List<int>, List<string> ve List<double> listelerine dönüştürün.

List<object> objectList = new List<object> { 129, 14, 3.14, 1.6, "Bünyamin", "Software", "Developer" };

List<string> stringList = new List<string>();
List<int> intList = new List<int>();
List<double> doubleList = new List<double>();


foreach (var item in objectList)
{
    if (item is string)
        stringList.Add((string)item);

    else if (item is int)
        intList.Add((int)item);

    else if (item is double)
        doubleList.Add((double)item);
}

Console.WriteLine("String List : ");
stringList.ForEach(Console.WriteLine);

Console.WriteLine(" ");

Console.WriteLine("Int Listesi : ");
intList.ForEach(Console.WriteLine);

Console.WriteLine(" ");

Console.WriteLine("Double Listesi : ");
doubleList.ForEach(Console.WriteLine);

#endregion

#region Soru7

// Kullanıcıdan alınan string türündeki bir tarihi DateTime türüne dönüştürün ve bu tarihin yıl, ay ve gün bileşenlerini ayrı ayrı yazdırın.

Console.WriteLine("Lütfen bir tarih giriniz");
string girilenTarih = Console.ReadLine();

if (DateTime.TryParse(girilenTarih, out DateTime date))
{
    Console.WriteLine($"Tarih Yılı : {date.Year}");
    Console.WriteLine($"Tarih Ayı : {date.Month}");
    Console.WriteLine($"Tarih Günü : {date.Day}");
}
else
    Console.WriteLine("Tarih Formatını Doğru Girinizi");

#endregion

#region Soru8

// string türünde bir liste içindeki sayıları önce int, sonra double, ardından tekrar string türüne dönüştürün ve her adımda bu değerlerin toplamını hesaplayın.

List<string> stringList = new List<string> { "129", "14", "489", "99", "66", "33" };

List<int> intList = stringList.Select(int.Parse).ToList();
Console.WriteLine($"İnt Toplam : {intList.Sum()}");


List<double> doubleList = intList.Select(item => (double)item).ToList();
Console.WriteLine($"Double Toplam: {doubleList.Sum()}");

#endregion