namespace HomeWorks_16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        double sayi1 = 3.14159d;
        float sayi2 = (float)sayi1;
        System.Console.WriteLine(sayi1);
        System.Console.WriteLine(sayi2);

        //şuan da iki değişkene de verdiğimiz değer muhtemelen iki değişkeninde bitlerine uygun olduğu için herhangi bir fark göremiyoruz yazdırdığımızda ama eğer sayıyı biraz daha büyüttüğümüz de hassasiyet farkını gözlemleyebiliriz aşağıdaki örnekte olduğu gibi 

        double sayi3 = 3.1415931231232131212d;
        float sayi4 = (float)sayi3;
        System.Console.WriteLine(sayi3);
        System.Console.WriteLine(sayi4);

    }
}
