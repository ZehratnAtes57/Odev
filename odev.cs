Random random = new Random();

int[] sayilar = new int[10];
Console.Write("Random sayı dizimizdeki sayilar: ");

for (int i = 0; i < sayilar.Length; i++)
{ 
    sayilar[i] = random.Next(1000);
    if (i != sayilar.Length - 1)
        Console.Write(sayilar[i] + ", ");
    else Console.WriteLine(sayilar[i]);
}

int tekadedi = 0;
int ciftadedi = 0;

for(int i = 0;i < sayilar.Length;i++)
{
    if (sayilar[i] % 2 == 0) 
        ciftadedi++;
    else
        tekadedi++;
}

int enkucuk = sayilar[0];
int enkucuksira = 0;
int enbuyuk = sayilar[0];
int enbuyuksira = 0;

for(int i = 0; i<sayilar.Length;i++)
{
    if(sayilar[i] > enbuyuk)
    {
        enbuyuk = sayilar[i];
        enbuyuksira = i + 1;
    }

    if (sayilar[i] < enkucuk)
    {
        enkucuk = sayilar[i];
        enkucuksira = i + 1;
    }
}

Console.WriteLine("Random sayı dizimizin cift adedi:" + ciftadedi);
Console.WriteLine("Random sayı dizimizin tek adedi:" + tekadedi);

Console.WriteLine("Random sayı dizimizin en büyüğünün sırası:" + enbuyuksira);
Console.WriteLine("Random sayı dizimizin en küçüğünün sırası:" + enkucuksira);

Console.Write("Bir sayı giriniz: ");
string giris = Console.ReadLine();
int sayi;

while(! int.TryParse(giris, out sayi))
{
    Console.Write("Lütfen rakamla sayı giriniz: ");
    giris = Console.ReadLine();
}
sayi = int.Parse(giris);

Console.Write("Girdiginiz sayıdan büyük sayılar: ");

for(int i = 0; i < sayilar.Length; i++)
{
    if( sayi < sayilar[i])
    {
        if (i != sayilar.Length - 1)
            Console.Write(sayilar[i] + ", ");
        else
            Console.WriteLine(sayilar[i]);
    }

}