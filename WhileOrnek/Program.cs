// Birinci aşama Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" Yazan while döngüsü.
int i = 0;
while (i < 10) 
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine("-----------------------");

// İkinci aşama 1 ile 20 arasındaki sayıları konsol ekranına yazdıran while döngüsü.
int a = 1;
while (a <= 20)
{
    Console.WriteLine($"{a}");
    a++;
}
Console.WriteLine("-----------------------");

// Üçüncü aşama 1 ile 20 arasındaki çift sayıları konsol ekranına yazdıran while döngüsü.
int b = 2;
while (b <=20 )
{
    Console.WriteLine($"{b}");
    b+=2;
}
Console.WriteLine("-----------------------");

// Dördüncü aşama 50 ile 150 arasındaki sayıların toplamını ekrana yazdıran while döngüsü.
int toplam = 0;
int c = 50;
while (c <= 150)
{
    toplam += c;
    c++;
}
    Console.WriteLine($" {toplam}");
    Console.WriteLine("-----------------------");
// Beşinci aşama 1 ile 120 arasındaki çift ve tek sayıların toplamını ayrı ayrı ekrana yazdıran while döngüsü.
int d = 1;
int oddSum = 0;
int evenSum = 0;
while(d <= 120)
{
    if (d % 2 == 0)
    {
         evenSum += d;
    }
    else
    {
        oddSum += d;
    }
   d++;
}
Console.WriteLine($"Çift sayıların toplami: {evenSum}");
Console.WriteLine($"Tek sayilarin toplami: {oddSum}");



