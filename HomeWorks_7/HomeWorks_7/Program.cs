namespace HomeWorks_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        

        int sayi1 = 1000000;
        byte sayi2 = (byte)sayi1;
        System.Console.WriteLine(sayi2);



        // sayi2 değişkenimizi byte tipine dönüştürdüğümüz için 1000000 değeri alamayız çünkü byte tipi 8 bitlik bir değişken türü olduğu için maksimum verebileceğimiz değer 255'tir bu nedenle vscode bizim için değişkene yerleştirdiğimiz 1000000 sayısının yani 8 bitlik byte karşılığı olan 64 sayısını yazdırır.
    }
}
