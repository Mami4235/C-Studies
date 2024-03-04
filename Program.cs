﻿using System;
using System.Runtime.CompilerServices;

namespace deneme1
{
    internal class Program
    {
        // int a; //Globaldir. Eğer Main altında yazarsak Local Olur.

        static void Main(string[] args)
        {
            #region Const kilitleme
            //int a = 5; int b=6; int c = 7;

            //Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            //const double pi = 3.14;


            //Conso0le.WriteLine(pi);
            #endregion

            #region Aynı Türde Birden Fazlda Değişkeni Tek İmzada Tanımlama.

            //int a = 5
            //int b = 10

            //int a = 5, b = 10;
            #endregion

            #region Deep copy
            //Derin kopyalama
            //Eldeki veri çoğaltılır, kopyalanır.

            // int a = 5;
            //int b = a;

            // a = a * 5;

            // Console.WriteLine(a);   
            // Console.WriteLine(b);       

            #endregion

            #region Boxing ve UnBoxing
            //Object Nedir?   Referans türlü bir değişkendir
            //  Boxing = > object türe bir değer atamak.
            //  UnBoxing = > Object edilmiş bir değeri kendi türünde elde etmektir.

            // Tümmm türler varsayımsal olarak object ten türerler.
            //object=> number,char,string,bool,int..vs.

            //int yas = 26;
            // object _yas = 26; //Boxing işlemi objectin içerisinde kendi türüyle saklanır. Lakin! _yas değişkeni bizlere objeckt türde getirecektir.
            #endregion

            #region Var Keywordü
            // Var Keywordü Türünü bilmediğimiz değişkenleri var ile compailere yaptırabiliriz. diller arasında entegrasyonda kullanılır.
            // Asıl sebebi Farklı diller arasında desteklenemeyen türlerdeki verileri karşılayabilmek için oluşturulmuş ortak bir keyworddür.
            #endregion

            #region (Checked) Sayısal İfadelerin Tür Dönüşümleri
            // Bilinli tür dönüşümlerinde veri kaybı söz konusu olursa eğer runtime'da bizleri uyaracak olan bir kontrol mekanizmasıdır.
            //   checked
            {
                // int a = 500;
                // byte b = (byte)a;
                // Console.WriteLine(b);

            }
            #endregion

            #region ASCII (char türünün Sayısal türe dönüştürülmesi.)
            //char a = 'a';                  // Cast operetörü ; UnBoxing, bilinçli tür dönüşümü ve burada kullandık.
            //int _a = (int)a;
            //Console.WriteLine(_a);
            #endregion

            #region Mantıksal Operatörler (ve &&)
            //Patates ve Köfte
            //true    && true
            #endregion

            #region veya || 
            //veya(||) operatörü,  şartlardan enn az birinin yerine getirilmiş olması yeterlidir.
            //Patates veya Köfte
            //true/false    ||   false/true
            #endregion

            #region ya da ^
            // yada (^) operatörü, şartlarrdan kesinlikle bir tanesinin yerine getirilmesini ister...
            #endregion

            #region Ternary Operatörü
            //Bir değişkene/ metoda/proprty'e değer atarken, eğer ki bu değer şerta göre fark edecekse;
            //satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür.

            //bool medeniHal = true;
            // string mesaj = medeniHal == true ? "Evlilere kampanya" : "Bekarlara kampanya...";
            //Console.WriteLine(mesaj);
            #endregion

            #region Birden Fazla Conditadion Uygulamak
            // int yas = 25;
            // Yaşı 25'den küçük olanlara A, 25 olanlara B ve 25'den büyük olanlara C değerini döndüren ternary operatörü oluşturalım.
            // string sonuc = yas < 25 ? "A" : ( yas == 25 ? "B" : "C" );
            //Console.WriteLine( sonuc );
            #endregion

            #region Ternary operatörü Örnek
            //string havaDurumu = "Muhammet Ali AlTOK";

            //Console.WriteLine(havaDurumu == "Yağmurlu"? "Şamsiye almalısın" : (havaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle..." : "Yağmur yağabilir."));
            #endregion

            #region Cast Operatörü
            // Genellikle tür dönüşümlerinde kullanılan bir türdür.
            //1. Boxing -> Unboxing 
            // object x = 123;
            //int x2 = (int)x;

            // 2. Bilinçli Tür Dönüşümleri 
            // int a = 5;
            // short b = (short)a;

            //3. Char -> int | int -> Char ( ASCII)
            //int ascii = 93;
            //char c = (char)ascii;

            //*****İleride polimorfizm durumunda base class referansıyla işaretlenen bir nesneyi kendi türünde de elde edebilmemizi sağlamaktadır.
            #endregion

            #region if Yapılanması
            // bool medeniHal = true;
            //if (medeniHal == true)
            //{
            //   Console.WriteLine("Allah tek yastıkta kocatsın...");
            // }
            //if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır.
            // ifyapılanmasında illa ki else kullanmak zorunda değiliz.
            #endregion

            #region if - else yapılanması
            //int i = 10;
            //   if(i > 5)
            // {

            //    Console.WriteLine("i değeri 5'ten büyüktür.");
            // }
            //     else
            // {
            //    Console.WriteLine("i değeri 5'ten küçüktür.");
            // }
            #endregion

            #region Akış Kontrol Mekanizmaları - if Yapısı Örnek 1
            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL'den fazla ise, 2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
            //// Console.Write("Lütfen birinci ürürün fiyatını giriniz : ");
            ////int birinciUrununFiyati = int.Parse(Console.ReadLine());
            //// Console.Write("Lütfen ikinci ürünün fiyatını giriniz : ");
            //// int ikinciUrununFiyati = int.Parse(Console.ReadLine());

            //int toplam = birinciUrununFiyati + ikinciUrununFiyati;
            //if(toplam > 200)
            //{
            //....... 
            // }

            //Bu Şekildede yapılabilir lakin toplam'a atadığımızda boşa ramda yer kaplıyacağı için kısaca aşağıdaki gibide yapılabilir.

            //// if (birinciUrununFiyati + ikinciUrununFiyati >200 )
            //// {
            // int toplamSonTutar = birinciUrununFiyati + (ikinciUrununFiyati * 75 / 100);
            // Console.WriteLine(toplamSonTutar);
            ////   Console.WriteLine(birinciUrununFiyati + (ikinciUrununFiyati * 75 / 100));
            ////}
            //// else
            ////{ 
            ////   Console.WriteLine(birinciUrununFiyati + ikinciUrununFiyati);
            //// }
            #endregion

            #region Akış Kontrol Mekanizmaları - if Yapısı Örnek 2
            // Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı" , yanlış girildiğinde "Girdiğiniz kullanıcı adı veya Şifre hatalı" mesajı veren Console uygulamasını yapalım.
            //// Console.WriteLine("Lütfen kullanıcı adınızı yazınız.");
            //// string kullaniciAdi = Console.ReadLine();
            ////Console.WriteLine("Lütfen şifrenizi giriniz.");
            /////string sifre = Console.ReadLine();

            // if (kullaniciAdi == "Mami" && sifre == "12345")
            //{
            //     Console.WriteLine("Giriş Başarılı.");
            // }
            // else                           //// KENDİME NOT: Bu arada if ve else işlemlerimzde tek satırlı işlemler yaptığımız için scope'leri kaldırabiliriz.
            // {
            //     Console.WriteLine("Girdiğiniz Kullanıcı veya şifre hatalıdır.");
            // }

            // Eğerki Tek Satırda Yazmak İstersek Bu Şekildede Yazılabilir.
            /////Console.WriteLine(kullaniciAdi == "Mami" && sifre == "12345" ? "Giriş Başarılı." : "Girdiğiniz kullanıcı adı veya şifre hatak-lıdır.");
            #endregion

            #region Akış Kontrol Mekanizmaları - if Yapısı Örnek 3
            //Kullanıcıdan alınan iki sayının ve yapılacak işlem türünün (toplama, çıkarma, çarpma, bölme) seçimleriyle hesaplayan programı yazalım.
            //// Console.WriteLine("İlk sayıyı giriniz.");
            ////int sayi1 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("İkinci sayıyı giriniz.");
            //// int sayi2 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Lütfen yapılacak işlemi bildiriniz (+, -, *, /)");
            ////char islem = char.Parse(Console.ReadLine());

            #region 1. Kritik
            ////if (islem == '+')
            ////{
            ////   Console.WriteLine(sayi1 +sayi2);
            //// }
            ////else if (islem == '-')
            ////{
            /////Console.WriteLine(sayi1 - sayi2);
            //// }
            ////else if (islem == '/')
            //// {
            ////   Console.WriteLine(sayi1 / sayi2);
            ////}
            //else if (islem == '*')
            //// else
            ////{
            ////    Console.WriteLine(sayi1 * sayi2);
            ////}
            #endregion

            #region 2. Kritik
            //// switch (islem) 
            //// {
            ////  case '+':
            ////      break;

            ////   case '-':
            ////      break;

            //// case '*':
            ////     break;

            //case '/':    Buda kullanılabilir aşağıdaki gibi defaultta.
            //    break;
            ///// default:
            ////    break;
            //// }

            #endregion

            #region 3. Kritik
            //// int sonuc = islem switch
            ////  {
            /////  '+' => sayi1 + sayi2,
            ////  '-' => sayi1 - sayi2,
            ////  '/' => sayi1 / sayi2,
            //'*' => sayi1 * sayi2,
            //// _ => sayi1 * sayi2,

            //// };
            //// Console.WriteLine(sonuc);
            #endregion
            #region 4. Kritik
            ////Console.WriteLine(islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1 - sayi2 : (islem == '/' ? sayi1 / sayi2 : sayi1 * sayi2)));
            #endregion
            #endregion

            #region Akış Kontrol Mekanizmaları - if Yapısı Örnek 4
            // Girilen sayının değeri 10 değilse ekrana 'sayı yanlış' yazdıralım.

            ////int sayi = int.Parse(Console.ReadLine());
            #region Kritik 1 
            // if illa else ile birlikte kullanılmak zorunda değildir. Tek başına kullandığımızda kod maliyetimiz azalır bu yüzden alttaki çözümü kullanmalıyız.
            ////if (sayi == 10)
            ////{

            ////}
            //// else
            ////{
            ////   Console.WriteLine("sayı yanlış.");
            ////}
            #region Kritik 2 
            //  En Doğru çözüm budur. 
            //// if (sayi != 10) 
            //// {
            ////    Console.WriteLine("sayı yanlış.");
            ////}
            #endregion
            #region Kritik 3 
            //(ternary)
            ////Console.WriteLine(sayi  == 10 ? "" : "sayı yanlış.");
            #endregion
            #endregion
            #endregion

            #region Akış Kontrol Mekanizmaları - if Yapısı Örnek 5
            //Girilen sayının negatif yada pozitif olduğunu gösteren uygulamayı yazalım.
            //// int sayi = int.Parse(Console.ReadLine());
            //// if (sayi < 0)
            ////     Console.WriteLine("Negatif");
            //// else
            ////     Console.WriteLine("Pozitif");

            // Eğer çıkan değeri kullanmamız gerekirse if'in dışına almamız lazım o zamanda izlememiz gereken yol aşağıdaki gibidir.

            //// int sayi = int.Parse(Console.ReadLine());

            //// string sonuc = "";

            ////if (sayi < 0)
            // Console.WriteLine("Negatif");
            ////    sonuc = "Negatif";
            //// else
            // Console.WriteLine("Pozitif");
            ////     sonuc = "Pozitif";
            //// Console.WriteLine(sonuc);
            #endregion

            #region Type Pattern
            //// object x = "Altok";
            ////if(x is string a)
            //// { 
            // string _x = (string)x;     Type pattern 7.0 dan sonra buna gerek kalmadı yukarıda direk 'a' diye tanımlayabiliyoruz.
            ////     Console.WriteLine(a);
            ////  }
            //Console.WriteLine(a);           Null gelebileceği için burada hata veriyor lakin ifin içerinde yazabiliyoruz her halukarda dolu geleceği için.
            #endregion

            #region Constant Pattern
            //// object x = 123;
            //// int a = 123;
            ////  Console.WriteLine(a is 123);        // buradaki 'is' '==' ile ayını sorgu niteliğini taşıyor.
            ////if (x is 123)
            //// {

            //// }
            //// if (x is int)
            ////  {

            //// }
            #endregion

            #region Constant Pattern Kritik
            // is operatörü bir değişkenin türünü srmamızı/ belirlememizi sağlayan bir operatördür. Ve bu operatörün kullanıldığı değişkenleri türü illa bir referans türlü olmak zorunda değildir.
            //// int a = 5;
            ////  Console.WriteLine(a is int);
            //// Console.WriteLine(a is string); // Buradakiler ise normal is operatörünün kendi fıtratındaki işlemdir.
            ////  Console.WriteLine(a is bool);

            //// Console.WriteLine(a is 5); //Eğer ki is operatörüyle bir değişkenin değerini == operatörün sorumluluğuyla check ediyorsa işte buna constant pattern denmektedir...
            #endregion

            #region Var Pattern 
            ////object x = "Türkiye";
            ////if (x is var a)
            ////{
            ////    Console.WriteLine(a);
            ////}
            #endregion

            #region Recursive Pattern     
            // switch bloğunda referans türlü değişkeblerde kontrol edebilmektedir.
            // switch teki çoğu özelliği getiren yeni bir pattern.
            // Ayrıca switch bloğunda when komutu ile çeşitli şart/koşul niteliği kazandırılmıştır.
            #endregion

            #region 7.0 Pattern Matching - Type ve Var Pattern Üzerine Kritik Yapalım
            ////object x = "çalışma";
            //// if ( x is string a)
            //// {
            ////    Console.WriteLine(a);
            //// }
            //// if (x is var b)
            //// {

            //// }

            //// bool result  = x is string o1;  // type pattern'da x değişkenin değerinin string olmama ihtimalinde o1'in null olma ihtimali söz konusu olduğu için kullanırken hata verir.
            //// Console.WriteLine(o1);

            //// bool result2 = x is var o2;   // var pattern'da ise x değişkeninin değeri ne olursa olsun var ile o2 ye atanacağından dolayı nul olma ihtimali yoktur o2 rahatça kullanılır.
            //// Console.WriteLine(o2);
            #endregion
            //--------------------------------------------------------------------------------------------------------------
            #region Hata Kontrol Mekanizmaları
            //Gerekirse yine bakarsın.
            #endregion

            #region Döngüler (For Döngüsü)
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("Muhammet Ali ALTOK");
            // }
            #endregion

            #region Örnek 1
            // 1 ila 40(Dahil) arasındaki çift sayıları toplayarak sonucu ekrana gösterelim.
            //// int toplamSonuc = 0;
            //// for ( int i = 1; i <= 40; i++)
            //// {
            ////     if ( i % 2 == 0 )
            ////     {
            ////          toplamSonuc += i;
            ////     }
            ////}
            //// Console.WriteLine("Toplamasonuç : " + toplamSonuc);
            #endregion

            #region Örnek 2
            // Klavyeden girilen sayının faktöriyelini bulan programı yapalım.

            //// int sayi = int.Parse(Console.ReadLine());

            #region 1. çözüm 
            //// int faktoriyel = 1;
            //// for (int i = 1; i<= sayi; i++)
            ////  {
            ////      faktoriyel *= i;
            ////}
            //// Console.WriteLine("Faktoriyel :" + faktoriyel);
            #endregion

            #region 2. Çözüm
            //// int faktoriyel = 1;
            ////  for (int i = sayi; i > 0; i--)
            //// {
            ////    faktoriyel *= i;
            ////  }
            //// Console.WriteLine("Faktoriyel : " + faktoriyel);
            #region turnery operatörlü çözüm2
            //// int faktoriyel = 1;
            /////string sonuc = "";
            ////  for (int i = sayi; i > 0; i--)
            //// {
            ////    faktoriyel *= i;
            ////    sonuc += i + (i == 1 ? " = " : " x ");
            ////   }
            //// Console.WriteLine("Faktoriyel : " + sonuc + faktoriyel);
            #endregion

            #endregion

            #endregion

            #region While Döngüsü (Şart doğrulandıkça tetiklenir.)
            // BİLGİ NOTU: While önce havaya bakar şamsiyeyi alır Do while iseşemsiyeyi alır sonra havaya bakar.
            //Örnek
            //0 andaki tarihin saniye değeri 5'in katıysa eğer tarihi ekranda gösteren uygulamayı yazalım.

            //// while (true)
            ////{
            ////    if (DateTime.Now.Second % 5 == 0)
            ////         Console.WriteLine(DateTime.Now);
            //// }
            #endregion

            #region Yardımcı Manevratik Komutlar
            //Kodu durdurmak, devamını okytmamak, var olan bir döngüden çıkış yapmak yahut komple metodu sonlandırmak yani kodu yönlendirmek için kullanılan komutlardır.
            // Manevratik komutlar yapamayacağımız şeyleri yapmamızı sağlayan komutlar dağildir, yapabileceklerimizi daha kısa/efektif/profesyonel yapmamızı sağlarlar...
            #endregion

            #region Break Komutu
            // Sadece "Switch - case" ve "Döngülerde" Kullanılır.
            // Kullanıldığı yapıdan çıkış yapılmasını/kullanıldığı yapıyı sonlandırmaya yarayan bir keywörddür. 

            //Örnek => Saniye 15 olduğunda break devreye girdiği için döngü sonlandı...

            //// while (true)
            //// {
            ////    if (DateTime.Now.Second == 15)
            ////        break;
            ////    Console.WriteLine(DateTime.Now);
            ////}
            #endregion

            #region Break Örnek
            // Kullanıcı 'm' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yazalım.

            //// int toplam = 0;
            ////while(true)
            //// {
            ////     Console.WriteLine("Lütfen bir sayı giriniz.");
            ////   string girilenDeger = Console.ReadLine();
            ////     if (girilenDeger == "m")
            ////     {
            ////         Console.WriteLine("Toplam Sonuç : " + toplam);
            ////        break; // Burada kullandığımız "Break" "m" değeri girildiğinde döngüyü sonlandırmak ve toplam alındıktan sonra tekrar bizden sayı istemesini önlemek.
            ////    }
            ////    else
            ////   {
            ////     toplam += int.Parse(girilenDeger);
            ////   }
            //// }
            #endregion

            #region Örnek 2
            // Kullanıcıdan alınan sonsuz adet sayı değerlerinden 37'nin katı girildiğinde sonlanan uygulamayı yazalım.

            //// while (true)
            //// {
            ////     Console.WriteLine("Lütfen bir sayı giriniz.");
            ////    int sayi = int.Parse(Console.ReadLine());
            ////    if (sayi % 37 == 0)
            ////     {
            ////         Console.WriteLine("Uygulama sonlanmıştır.");
            ////        break;
            ////    }
            //// }
            #endregion

            #region continue Komutu ve örnek
            // Sade ve sadece "Döngülerden" erişelebilen ve döngülerde kullanılabilen bir keywörddür.
            // Örnek
            //// for (int i = 0; i < 10; i++)
            //// {
            ////    if (i % 2 != 0)
            ////        continue;

            ////         Console.WriteLine(i);
            ////}
            #endregion

            #region Continue - Örnek 
            // Kullanıcını girdiği sonsuz adet sayıdan pozitif olanlarını çarpan ve 't'(enter) yapıldığında sonucu ekrana yazdıran kodu yazalım.
            ////carpim = 1;
            ////le (true)
            ////
            //// Console.WriteLine("Lütfen bir sayı giriniz.");
            ////string girilenDeger = Console.ReadLine();
            //// (girilenDeger == "t")
            ////
            ////   Console.WriteLine(carpim);
            ////   break;
            ////}
            ////    else // else olmak zorundada değil kaldırsakta kodumuz yine çalışacaktır ;)
            ////  {
            ////       int sayi =int.Parse(girilenDeger);

            #region 1. İhtimal
            //Buda olabilir lakin 2. ihtimal daha iyidir.
            //(sayi > 0)
            //
            //   carpim *= sayi;
            #region 2. İhtimal
            ////      if (sayi < 0)
            ////          continue;
            ////     carpim *= sayi;
            #endregion
            #endregion
            ////  }
            //// }
            #endregion

            #region goto Keywördü
            // Kodun sekranizasyonunu bozup, aksisi ters istikamete almamızı sağlayan bir manevratik komuttur. İstediğimiz koda geri döndürebiliyoruz.

            #endregion

            #region Diziler - Arrays
            // Diziler bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
            // Diziler referans türlü değerlerdir. Yani nesnel yapılardır. Özlerinde classtırlar.
            //Dizilerde elman sayısı kesinlikle belirtilmelidir. Bu bir sınırlılıktır.
            // Oluşturma Şekli Örn: type[]isim = new type [...adet...]; , int[] yaslar = new int [5]; , bool[] x = new bool[7]; , byte[] sayilar = new byte[n];vs...
            #endregion,

            #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme

            //// string[] personeller = new string[10];
            ////  personeller[0] = "Hilmi";
            ////  personeller[1] = "Hüseyin";
            ////  personeller[2] = "Rıfkı";
            ////  personeller[3] = "Şuayip";
            ////  personeller[4] = "muiddin";
            ////  personeller[5] = "Naci";
            ////  personeller[6] = "Hüsnü";
            ////  personeller[7] = "Nurullah";
            ////   personeller[8] = "Cabbar";
            ////  personeller[9] = "Akif";

            // for Döngüsü ile;

            //// for (int i = 0; i < 10; i++)
            //// {
            ////      Console.WriteLine(personeller[i]);
            //// }

            //do-wihile döngüsü ile;

            ////  int i = 0;
            ////  do
            ////  {
            ////     Console.WriteLine(personeller[i++]);
            ////  } while (i<10);

            #endregion

            #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme - Kritik 1
            //lenght => Dizinin kaç elemanlı olduğunu int olarak geriye döndürür.
            //lenght içerdeki kişi sayısı değiştirilsede bizim döngümüzde kod değişikliği yapmaya gerek bırakmadan kendişi kişi sayısı kadar dönecektir.
            //// string[] personeller = new string[13];
            ////   personeller[0] = "Hilmi";
            ////   personeller[1] = "Hüseyin";
            ////   personeller[2] = "Rıfkı";
            ////   personeller[3] = "Şuayip";
            ////   personeller[4] = "muiddin";
            ////   personeller[5] = "Naci";
            ////   personeller[6] = "Hüsnü";
            //// personeller[7] = "Nurullah";
            //// personeller[8] = "Cabbar";
            //// personeller[9] = "Akif";
            //// personeller[10] = "Ayşe";
            //// personeller[11] = "Fatma";
            //// personeller[12] = "Hayriye";

            //// for (int i = 0; i < personeller.Length; i++)
            //// {
            ////     Console.WriteLine(personeller[i]);
            //// }
            #endregion

            #region Dizi Tanımlama Varyasyonları
            #region 1. Varyasyon
            ////int[] yaslar = new int[3];
            //// yaslar[2] = 123;
            //// Console.WriteLine(yaslar[2]);
            #endregion

            #region 2. Varyasyon
            //// int[] yaslar2 = { 30, 25, 42, 49, };
            //// string[] isimler = { "Rıfkı", "Şuayip", "Mehmet", "Ahmet" };
            #endregion

            #region 3. Varyasyon
            //Aslnda 2.Varyasyon ile aynı sen hangisini tercih edersen onu kullanabilirsin.

            //// string[] isimler2 = new string[] { "Rıfkı", "Şuayip", "Mehmet", "Ahmet" };
            #endregion

            #region 4. Varyasyon
            // 3 ile sınırladığımız için 3 tane isim olması lazım eksik veya fazla olduğunda aşağıda olduğu gibi hata alırız..
            //// string[] isimler3 = new string[3] { "Rıfkı", "Şuayip", "Mehmet", "Ahmet" };
            #endregion

            #region 5. Varyasyon
            ////int[] sayilar = new[] {3 , 5 , 7};
            ////var sayilar2 = new[] {3 , 4 , 2 ,7};
            #endregion
            #endregion

            #region Array Sınıfı
            // Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedir.
            // Dolayısıyla dizilerde Array sınıfından gelen belirli metotalar ve özellikler mevcuttur.

            ////int[] a = new int[5]; // Dizi eğer ki kendi türünde referans ediliyorsa indexer operatörü kullanılabilir...
            // Bu Şekilde çalıştırıldığında ilgili diziye verisel müdahaleler operatif gerçekleştirilirken..
            // Genellikle bu format algoritmalarda tercih edilir. Çünkü indexer algoritmalarda çok kullanılabilir.

            //// Array a2 = new int[5]; // Yok eğer Array türünde referans ediliyorsa indexer operatörü kullanılmaz!
            // Bu şekilde ise fonksiyonel çözümler getirilmektedir.
            // Genellikle elimizdeki dizinin üstünde işlem yaparken tercih edilen formattır. Dizi hakkında bilgi edinirken vs. kullanılabilir.
            #region Array Türünden Dizilere Değer Atama / Okuma
            #region 1. Yöntem
            ////int[] dizi = new int[3];
            ////dizi[0] = 30;
            ////dizi[1] = 31;
            ////dizi[2] = 32;
            ////Array dizi2 = dizi;
            #endregion
            #region 2. Yöntem
            ////Array dizi = new int[3];
            ////dizi.SetValue(30, 0);
            ////dizi.SetValue(31, 1);
            ////dizi.SetValue(32, 2);

            ////object value = dizi.GetValue(1);
            ////Console.WriteLine(value);
            #endregion

            #endregion

            ////Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            #region Metotlar
            #region Clear
            //Dizi içerisindeki tüm elemenalrı siliyor diye bilinir. Halbuki bu yanlıştır. Dizi içerisindeki tüm elemanlara, dizinin türünü uygun default değerleri atayan bir fonksiyondur.
            ////Array isimler = new[] {"Hilmi" , "Hüseyin" , "Şuayip" , "Rıfkı" , "Hamdullah"};
            //Array.Clear(isimler, 0, isimler.Length);
            ////for (int i = 0; i < isimler.Length; i++)
            ////    Console.WriteLine(isimler.GetValue(i));
            ////Array.Clear(isimler, 1, 2);
            ////Console.WriteLine("**************************");
            ////for (int i = 0; i < isimler.Length; i++)
            ////    Console.WriteLine(isimler.GetValue(i));
            #endregion

            #region Copy
            // Elimizdeki dizinin verilerini bir başka diziye kopyalamamızı sağlayan bir fonksiyondur.
            //string[] isimler2 = new string[isimler.Length];

            //Array.Copy(isimler, isimler2, 5);
            //for (int i = 0; i < isimler2.Length; i++)
            //    Console.WriteLine(isimler2[i]);

            //Array.Copy(isimler, 2, isimler2, 0, 2);
            //for (int i = 0; i < isimler2.Length; i++)
            //    Console.WriteLine(isimler2[i]);
            #endregion

            #region IndexOf
            // Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
            // Arama neticesinde ilgili değer varsa int olarak o değerin index numarasını döndürecektir.
            // Yoksa -1 değerini döndürür.

            ////int index = Array.IndexOf(isimler, "Rıfkı");
            //// if (index != -1 )
            //// {
            ////     //Demek ki aranan değer ilgili dizide bulunmuktadır...
            ////     Console.WriteLine("Var.");
            //// }
            //// int index = Array.IndexOf(isimler, "Rıfkı", 0, 3) //İsimlerin içinde Rıfkı var mı ara ama 0. indisten 3. indise kadar demek.
            #endregion

            #region Reverse
            // Elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur.
            //for (int i = 0; i < isimler.Length; i++)
            //   Console.WriteLine(isimler.GetValue(i));
            //Array.Reverse(isimler);
            //Console.WriteLine("**************************");
            //for (int i = 0; i < isimler.Length; i++)
            //   Console.WriteLine(isimler.GetValue(i));
            #endregion

            #region Sort
            //Küçüktan büyüğe doğru sılama yapan bir fonksiyondur.
            #endregion



            #endregion

            #region Özellikler

            #region IsReadOnly 
            // Bir dizinin sadece okunabilir olup olmadığını bool türde bildiren bir özelliktir.
            //Console.WriteLine(isimler.IsReadOnly);
            #endregion

            #region IsFixedSize
            // Bir veri kümesinin eleman sayısının sabit olup olmama durumunu IsFixedSize ile Öğrenebilirsiniz.
            //// Console.WriteLine(isimler.IsFixedSize);
            // Tümmm dizilerde eleman sayısı sabit olacağı için sürekli true dönecektir. Örneğin ArrayList koleksiyonunda false dönmektedir.
            #endregion

            #region Length
            // İlgili diziye ait tüm eleman sayısını getirecektir.
            //// Console.WriteLine(isimler.Length);
            #endregion

            #region Rank
            // Bir dizinin derecesini bize döndürür.
            // Console.WriteLine(isimler.Rank);
            #endregion

            #endregion

            #region CreateIntance Metodu İle Dizi Tanımlama
            ////int[] yaslar = new int[3];
            // Normalde yukarıdaki gibi yapılan dizi tanımlaması esasında arkaplanda Array sınıfının CreateIntance muetodunu kullanmaktadır.
            // Bizlerde bu metodu kullanarak fonksiyonel diziler oluşturabilmekteyiz.
            /////Array yaslar2 = Array.CreateInstance(typeof(int), 3);
            #endregion
            #endregion

            #region (C# 8.0) Ranges and Indices inceleme
            ////int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78, };

            ////Range range = 5..10;
            ////var sayilar2 = sayilar[range];

            ////Range range = ..; // --> Tüm diziye karşılık gelir.
            //// '' ^ '' Dizinin Tersini almaya yarar bu iki operatör önemlidir.
            #endregion

            #region Çok Boyutlu Diziler
            //int[,,,] sayilar = new int[3, 4, 5, 6]; // 4 Boyutlu bir dizi tanımlaması bu şekilde gösterilir.
            #endregion

            #region String Türü ve String Gerçeği
            // String; referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
            //// int a = 5;
            //// string b = "Mami";

            #region Null - Empty Durumları, Farkları

            #region Null
            // Bir değişken/nullable/referans eğer ki null alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
            // Arsa yok!
            //Değer türlü değişkenler null alamazlar!
            //Null alabilen türler sadece referans türlerdir.
            // Değer türlü değişkenlerin null alabilmesi için nullable olmaları gerekmektedir.

            ////int? a = null;
            //// string b = null;

            //Nul olan bir değer üzerinde işlem yapmaya çalıştığımızda run time hatası meydana gelir. Amma velakin Empty olan bir değer üzerinde işlem gerçekleştirilebilir.

            #endregion
            #region Empty
            //Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir.Lakin alan tahsisinde bulunmuştur.
            //Arsa var lakin ev yok!
            //Tüm değerlere empt atanabilir.
            //Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
            // Default değerlerin olduğu durumlar empty olarak geçerler.

            ////int a = 0;
            //// bool b = false;
            ////int[] x = new int[55];

            //Empty dendiğinde aklınıza string'e "" değerinin verilmesi gelsin yeter!
            ////string a = "";
            ///// string a2 = string.Empty;
            ///Üstteki ikisi Aykı kapıya çıkar.

            //// string a = null;


            //Null bellekte yer kaplamaz!! ***** Empty her ne kadar değer almasada bellekte yer kaplayacak ve bir alan tahsisinde bulunmuş olacaktır...
            #endregion
            #endregion
            #endregion

            #region IsNullOrEmpty
            // Elimizde string ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.

            ////string x = ""; //Empty
            //String x = string.Empty; //Empty

            //if (x != "")
            //if (x != string.Empty && x != null)
            ////if (x != string.Empty && x is not null)
            // {
            //Operasyon...
            // }
            //IsNullOrEmpty foksiyonu; elimizdeki string ifadenin null yahut empty olup olmama durumları hakkında bir check yapar ve geriye bool türde sonuç dö8ner.

            //// if (!string.IsNullOrEmpty(x))
            // {
            //Operasyon...
            // }
            #endregion

            #region IsNullOrWhiteSpace
            //IsNullOrWhiteSpace foksiyonu : Elimizdeki string ifadenin null, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye bool true değerini döndüren bir fonksiyondur.

            ////string x = "   ";
            ////if (!string.IsNullOrWhiteSpace(x) )
            //{
            //    //Operasyon....
            //}
            #endregion

            #region String - char dizisi
            //string metin = "sebepsiz boş yere ayrılacaksan....";

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == 'e')
            //        Console.WriteLine(i);
            //}

            //int i = 0;
            //do
            //{
            //    if (metin[i] == 'e')
            //        Console.WriteLine(i);
            //    i++;
            //} while (i < metin.Length);
            #endregion

            #region String ifadelerde + Operatörü
            // String ifadelerde + operatörü kullanılabilmektedir.
            // İki string ifade arasında birleştirme görevi görür.
            ////string a = "Merhaba", b = "Dünya";
            ////Console.WriteLine(a+b);
            // Bir string ifade ile herhangi bir tür + operatörüyle işleme tabi tutulabilir.
            // + operatörü string bir ifadeyle herhangi bir türdeki ifadeleri işleme tabi tutarken object + string davranış sergileyecek ve sonuç olarak geriye string değer döndürecektir.
            // Dolayısıyla herhangi bir ifadeyi string'e dönüştürebilmek için o ifadeyi + "" ile işleme tutmak yeterli olabilir.

            //int a2 = 5;

            //a+a2
            //// Console.WriteLine(5+7+20+"ahmet");
            #endregion

            #region String Formatlandırma
            string isim = "Muhammet Ali", soyisim = "ALTOK", Tcno = "12345678910";
            int yas = 26;
            bool medeniHal = false;

           //Console.WriteLine("TC No : ........... olan ...... ....... şahsın bilgileri | Yaş : .. | Medeni Hal : ...");

            #region + Operatörü
            Console.WriteLine("TC No : "+ Tcno +" olan "+ isim +" "+soyisim+" şahsın bilgileri | Yaş : "+yas+" | Medeni Hal : "+(medeniHal ? "Evli" :"Bekar"));
            #endregion
            #endregion
        }
    }
}