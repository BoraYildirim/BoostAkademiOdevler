int sonuc = 0;

for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {

        sonuc = i * j;
        Console.WriteLine(i + "x" + j + "=" + sonuc);
    }
}


Console.WriteLine("bir içecek kodu giriniz");
string kod = Console.ReadLine();

if (kod == "C" || kod == "c")
{
    Console.WriteLine("Çay");
}
else if (kod == "K" || kod == "k")
{
    Console.WriteLine("Kahve");
}
else if (kod == "L" || kod == "l")
{
    Console.WriteLine("Limonata");
}
else
    Console.WriteLine("yanlış kod girdiniz");


Console.WriteLine("içecek kodunu giriniz");
string code = Console.ReadLine();

string k, l, c;

switch (code)
{

    case "k":
        Console.WriteLine("kahve");
        break;
    case "c":
        Console.WriteLine("çay");
        break;
    case "l":
        Console.WriteLine("limonata");
        break;


    default:
        Console.WriteLine("tanımsız kod lütfen tekrar deneyiniz");
        break;
}

Console.WriteLine("Lütfen arka plan rengi seçiniz");

string renk = Console.ReadLine();

if (renk == "mavi")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (renk == "sari")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (renk == "yesil")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (renk == "kirmizi")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else
    Console.WriteLine("geçersiz renk tekrar deneyiniz");


Console.WriteLine("suanki renginiz");