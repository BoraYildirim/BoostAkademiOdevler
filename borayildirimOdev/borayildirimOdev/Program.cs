using System.ComponentModel.Design;

Console.WriteLine("ilk sayiyi giriniz");
double sayi1 = double.Parse(Console.ReadLine());
Console.WriteLine("ikinci sayiyi giriniz");
double sayi2 = double.Parse(Console.ReadLine());
Console.WriteLine("Yapmak istediğiniz işlemi giriniz");
string islem = Console.ReadLine();
double toplam = 0;
if (islem == "toplama")
{ toplam = sayi1 + sayi2;
    Console.WriteLine(toplam); }
else if (islem == "çarpma")
{ toplam = sayi1 * sayi2;
    Console.WriteLine(toplam); }
else if (islem == "çıkarma")
{
        toplam = sayi1 - sayi2;
        Console.WriteLine(toplam);
}
else if (islem == "bölme")
{ toplam = sayi1 / sayi2;
    Console.WriteLine(toplam); }
else
{ Console.WriteLine("Geçersiz işlem tekrar deneyiniz"); }