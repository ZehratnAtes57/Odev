int satirAdet;
Console.Writeline("satır adedi girin");
satirAdet = int.Parse(Console.ReadLine());
int sayi = 0;

while (!int.TryParse(satirAdet, out sayi))
{
    Console.WriteLine("Lütfen rakam ile giriniz");
    Console.WriteLine("satır adedi girin");
    satirAdet = Console.ReadLine();
}

Console.WriteLine("yazdırmak istediğiniz karakteri giriniz");
string deger = Console.ReadLine();

Console.WriteLine("yazdırmak istediğiniz ikinci karakteri giriniz");
string degeriki = Console.ReadLine();

for(int i = 1; i<= satirAdet; i++)
{
        if (i % 2 == 0)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(deger);
            }
        }
        else
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(degeriki);
            }
        }
    Console.WriteLine();
}

for (int i =  satirAdet-1; i >= 1; i--)
{
        if (i % 2 == 0)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(deger);
            }
        }
        else
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(degeriki);
            }
        }
    Console.WriteLine();
}

