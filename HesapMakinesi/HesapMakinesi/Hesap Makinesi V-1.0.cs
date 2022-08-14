bool conditionForLoop = true;
int total = 0;
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Cikarma");
Console.WriteLine("3. Carpma");
Console.WriteLine("4. Bolme");
Console.WriteLine("5. Cikis");
Console.Write("Lutfen bir secim yapin: ");
int option = int.Parse(Console.ReadLine());

if (option != 5)
{
    while (conditionForLoop)
    {
        Console.WriteLine("1. Sayiyi giriniz: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2. Sayiyi giriniz: ");
        int num2 = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
                total = num1 + num2;
                Console.WriteLine("Islem sonucu: " + total);
                break;
            case 2:
                total = num1 - num2;
                Console.WriteLine("Islem Sonucu: " + total);
                break;
            case 3:
                total = num1 * num2;
                Console.WriteLine("Islem sonucu: " + total);
                break;
            case 4:
                float divTotal = (float)num1/(float)num2;
                Console.WriteLine("Islem Sonucu: " + divTotal);
                break;
            default:
                Console.WriteLine("Gecersiz islem");
                break;
        }
        Console.WriteLine("Devam etmek ister misiniz (e/h)");
        string cevap = Console.ReadLine();
        if (cevap == "e")
        {
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cikarma");
            Console.WriteLine("3. Carpma");
            Console.WriteLine("4. Bolme");
            Console.WriteLine("5. Cikis");
            Console.Write("Lutfen bir secim yapin: ");
            option = int.Parse(Console.ReadLine());
            continue;
        }
        else if(cevap=="h")
        {
            conditionForLoop = false;
            Console.WriteLine("Program sonlandirildi");
        }
            
        
    }
}
else
{
    Console.WriteLine("Program sonlandirildi");
}