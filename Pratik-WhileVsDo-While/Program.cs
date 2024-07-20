Console.WriteLine("Bir limit değeri giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

//While kullanarak yaptım. While kullandığımız için şart sağlanıyor ise döngü dönüyor sadece eğer sağlanmıyorsa dönmüyor.
if (0 <= limit)
{
    int sayac = 0;
    while (sayac <= limit)
    {
        Console.WriteLine($"{sayac} Ben bir Patika'lıyım!");
        sayac++;
    }
}
else
{
    Console.WriteLine("0'dan küçük değer girdiniz.");
}

// Do-While şart sağlanmasa bile en az 1 kere dönüyor.
int sayac = 0;
do
{
    if (limit >= 0)
    {
        Console.WriteLine($"{sayac} Ben bir Patika'lıyım!");
        sayac++;
    }
    else
    {
        Console.WriteLine("0'dan küçük değer girdiniz.");
        break;
    }
} while (limit >= sayac);

