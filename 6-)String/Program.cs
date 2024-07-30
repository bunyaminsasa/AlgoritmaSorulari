
#region Soru1


// Bir string listesinde, her bir string'in belirli bir kelimeyi içerip içermediğini kontrol eden bir program yazın.


List<string> liste = new List<string> { "Hello World", "C# programming", "Learn coding" };

string kelime = "code";

foreach (string item in liste)
{
    bool durum = item.Contains(kelime);
    Console.WriteLine($"{item}: {durum}");
}

#endregion


#region Soru2

// Bir string her bir string'in "C#" ile başlayıp başlamadığını kontrol eden bir program yazın.


List<string> liste = new List<string> { "Hello World", "C# programming", "Learn coding" };

string kelime = "C#";

foreach (string item in liste)
{
    bool durum = item.StartsWith(kelime);
    Console.WriteLine($"{item}: {durum}");
}

#endregion


#region Soru3


// Bir string listesinde, "Start" ile başlamayan string'leri filtreleyen bir program yazın.

List<string> liste = new List<string> { "Start now", "Stop later", "Start again" };

List<string> yeniListe = liste.Where(w => !w.StartsWith("Start")).ToList();

foreach (string item in yeniListe)
{
    Console.WriteLine(item);
}

#endregion


#region Soru4


// Bir string içerisinde belirli bir kelimenin geçtiği tüm pozisyonları bulan bir program yazın.


string metin = "C# is a powerful programming language. I love programming in C#.";

string kelime = "programming";

int sonuc = metin.IndexOf(kelime);

while (sonuc != -1)
{
    Console.WriteLine(sonuc);
    sonuc = metin.IndexOf(kelime, sonuc + kelime.Length);
}


#endregion


#region Soru5


// Bir stringe belirli bir kelimenin öncesinde başka bir string ekleyen bir fonksiyon yazın.

string metin = "I love programming.";

string yeniMetin = metin.Insert(metin.IndexOf("programming"), "C# ");

Console.WriteLine(yeniMetin);



#endregion


#region Soru6


// Bir string'in belirli bir kelimesini silen bir fonksiyon yazın.


string metin = "I love programming in C#.";

string kelime = "programming ";

int index = metin.IndexOf(kelime);

string yeniMetin = index >= 0 ? metin.Remove(index, kelime.Length) : metin;

Console.WriteLine(yeniMetin);



#endregion


#region Soru7

// Bir string'i birden fazla karaktere göre ayıran bir fonksiyon yazın.

string metin = "apple, banana; cherry|date";

string[] meyveler = metin.Split(new char[] { ',', ';', '|' });

foreach (string meyve in meyveler)
{
    Console.WriteLine(meyve.Trim());
}



#endregion

