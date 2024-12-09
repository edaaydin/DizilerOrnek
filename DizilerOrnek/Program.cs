//// Console, convert, math, string,, datetime, char
////array

//// Struct class : üyeler vardir. Constructor metod (yapici metot), Property (özellik),
//// method (metot), field, const


#region N boyutlu dizi

////int[] vizeler = { 45, 79, 80, 21 };
////int[] finaller = { 66, 90, 60, 21 };

////int[,] tumSİnavlar = new int[4, 2] { { 45, 66 }, { 79, 90 }, { 80, 60 }, { 21, 21 } };

////Console.WriteLine(tumSİnavlar[4, 1]);

////Console.WriteLine("Tüm sınavlar:");

////foreach (var not in tumSİnavlar)
////{
////    Console.Write(not + " ");
////}
#endregion


#region Ornek1
////tek boyutlu bir integer dizisi oluşturun ve dışardan gelecek adete göre veri alacak ve sınav notları tutulacak.

//Console.Write("Kaç öğrenci var? ");
//int ogrenciSayisi = int.Parse(Console.ReadLine());

//int[] sinavNotlari = new int[ogrenciSayisi]; // Öğrenci sayısına göre bir int dizisi oluşturuyoruz


//for (int i = 0; i < ogrenciSayisi; i++) // Diziye sınav notlarını kullanıcıdan alarak ekliyoruz
//{
//    Console.Write($"{i + 1}. öğrencinin sınav notunu girin: ");
//    sinavNotlari[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("\nÖğrencilerin sınav notları:");
//for (int i = 0; i < ogrenciSayisi; i++)
//{
//    Console.WriteLine($"{i + 1}. öğrenci: {sinavNotlari[i]}");
//}
#endregion


#region Ornek
//int[] yuzdenBuyukSayilar = new int[ogrenciSayisi];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"{i + 1}. sayıyı girin: ");
//    int sayi = int.Parse(Console.ReadLine());

//    // Eğer sayı 100'den büyükse listeye ekle
//    if (sayi > 100)
//    {
//        yuzdenBuyukSayilar.Add(sayi);
//    }
//} 
#endregion

////int[] sayilar = new int[10];
////Console.WriteLine("10 adet sayi giriniz:");

////for (int i = 0; i < 10; i++)
////{
////    Console.WriteLine($"{i + 1}. sayiyi giriniz: ");
////    sayilar[i] = int.Parse(Console.ReadLine());
////}

////int[] yuzdenBuyukler = new int[10];

////int sayac = 0;

////for (int i = 0; i < 10; i++)
////{
////    if (sayilar[i] > 100)
////    {
////        yuzdenBuyukler[i] = sayilar[i];
////        sayac++;
////    }
////}

////Random rnd = new Random();
////int[] sayilar = new int[15];
////for (int i = 0; i < 15; i++)
////{
////    sayilar[i] = rnd.Next();
////}
////Array.Sort(sayilar);

////foreach (int i in sayilar)
////{
////    Console.WriteLine(i);
////}

////int[] sayi = new int[50];




#region Ornek
// for dogusu içinde rastgele  -50 50 sayi al 
// alınan sayıyı diziye ata 
// foreach ile ekrana yazdırırken, sayinın yanına negatif ise negatif yazsın

//int[] sayilar = new int[49];
//Random r = new Random();
//bool flag = false;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    // random sayi al ve bir degiskende tut
//    // bu sayi dizi içinde var mı kontrol et
//    // yoksa diziye ekle varsa yeni sayi ekle

//    int randomSayi = r.Next(1, 50);

//    // bu sayi dizi içinde var mı kontrol et.
//    foreach (int sayi in sayilar)
//    {
//        if (sayi == randomSayi)
//            flag = true;
//    }
//    // yoksa diziye ekle, varsa yeni sayi iste
//    if (!flag)
//    {
//        sayilar[i] = randomSayi;
//    }
//    else
//    {

//        i--;
//        flag = false;
//    }
//}
//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//} 
#endregion


#region Ornek
//Kullanıcı tarafından doldurulan 10 boyutlu bir dizideki en büyük ve en küçük değeri dizi fonksiyonlarını kullanmadan bulun ve ekrana yazdırın

//Console.Write("1. sayıyı girin: ");
//// int[] sayi = new int[10];
//int sayi = int.Parse(Console.ReadLine());

//int enBuyuk = sayi;
//int enKucuk = sayi;

//// Kalan 9 sayıyı kullanıcıdan alıyoruz ve karşılaştırıyoruz
//for (int i = 2; i <= 10; i++)
//{
//    Console.Write($"{i}. sayıyı girin: ");
//    sayi = int.Parse(Console.ReadLine());

//    // Girilen sayı mevcut en büyükten büyükse güncelle
//    if (sayi > enBuyuk)
//    {
//        enBuyuk = sayi;
//    }

//    // Girilen sayı mevcut en küçükten küçükse güncelle
//    if (sayi < enKucuk)
//    {
//        enKucuk = sayi;
//    }
//}
//// En büyük ve en küçük sayıyı ekrana yazdırıyoruz
//Console.WriteLine($"\nEn büyük sayı: {enBuyuk}");
//Console.WriteLine($"En küçük sayı: {enKucuk}"); 
#endregion


#region Ornek
//int[] sayilar = new int[boyut];

// Kullanıcıdan sayıları alıyoruz
//int toplam = 0;
//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.Write($"{i + 1}. sayıyı girin: ");
//    sayilar[i] = int.Parse(Console.ReadLine());
//    toplam += sayilar[i]; // Sayıların toplamını hesaplıyoruz
//}

//// Dizinin ortalamasını hesaplıyoruz
//double ortalama = (double)toplam / sayilar.Length;
//Console.WriteLine($"\nDizinin ortalaması: {ortalama}");

//// Ortalamanın altında kalan elemanları bulmak için bir liste kullanıyoruz
//List<int> ortalamaAltindakiSayilar = new List<int>();

//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (sayilar[i] < ortalama)
//    {
//        ortalamaAltindakiSayilar.Add(sayilar[i]); // Ortalama altındaki sayıları listeye ekliyoruz
//    }
//}

//// Ortalamanın altında kalan sayıları ekrana yazdırıyoruz
//Console.WriteLine("\nOrtalamanın altında kalan sayılar:");
//foreach (int sayi in ortalamaAltindakiSayilar)
//{
//    Console.WriteLine(sayi);
//} 
#endregion


#region Ornek
// Kisinin maasini hesaplama 

/*
kisi dizisi al kullanıcıdan 
maas al 
saat al 
maas * saat = kisinin maasi oluyor.
 */

//for (int i = 0; i < dizi.Length; i++)
//{
//    Console.Write($"Lutfen {i + 0}. index sayinizi giriniz : ");
//    alinanSayi = int.Parse(Console.ReadLine());

//    dizi[i] = alinanSayi; // Dizinin içini kullanıcıdan aldigim degerle doldurcam.
//}


//int[] maaslar = new int[3];
//int[] saatler = new int[3];
//string[] isimler = new string[3];
//int alinanMaas;



//for (x = 0; x < maaslar.Length; x++)
//{
//    Console.Write($"Lutfen {x + 0}. indexteki maasinizi giriniz : ");
//    girilenMaas = Convert.ToInt32(Console.ReadLine());
//    Console.Write("*********************\n");

//    girilenMaas = maaslar[x];
//}
//Console.Write("*********************\n");
//for (y = 0; y < saatler.Length; y++)
//{
//    Console.Write($"Lutfen {y + 0}. indexteki calisma saatinizi giriniz : ");
//    girilenSaat = Convert.ToInt32(Console.ReadLine());

//    girilenSaat = saatler[y];
//}
//Console.Write("*********************\n");

//for (z = 0; z < isimler.Length; z++)
//{
//    Console.Write($"Lutfen {z + 0}. indexteki isminizik giriniz : ");
//    girilenIsım = Console.ReadLine();

//    girilenMaas = maaslar[z];
//}
//maaslar[x] * saatler[y] = alinanMaas;


//Console.Write("*********************\n");
//Console.WriteLine($"{isimler[z]} adlı çalışanın maaşı: {alinanMaas} TL");

#endregion

#region ismi, ucreti ve saati kullanıcıdan alınan 3 dizilik maas hesaplama programi

//int[] ucretler = new int[3];
//int[] saatler = new int[3];
//string[] isimler = new string[3];
//int alinanMaas;

//// Maaşları kullanıcıdan alalım
//for (int x = 0; x < ucretler.Length; x++)
//{
//    Console.Write($"Lutfen {x}. indexteki maasinizi giriniz: ");
//    ucretler[x] = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("*********************");
//}

//// Çalışma saatlerini kullanıcıdan alalım
//for (int y = 0; y < saatler.Length; y++)
//{
//    Console.Write($"Lutfen {y}. indexteki calisma saatinizi giriniz: ");
//    saatler[y] = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("*********************");
//}

//// İsimleri kullanıcıdan alalım
//for (int z = 0; z < isimler.Length; z++)
//{
//    Console.Write($"Lutfen {z}. indexteki isminizi giriniz: ");
//    isimler[z] = Console.ReadLine();
//    Console.WriteLine("*********************");
//}

//// Maaşları hesaplayıp gösterelim
//for (int i = 0; i < isimler.Length; i++)
//{
//    alinanMaas = ucretler[i] * saatler[i]; // Maaş hesaplama
//    Console.WriteLine($"{isimler[i]} adlı çalışanın maaşı: {alinanMaas} TL");
//}
#endregion