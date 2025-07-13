using Encapsulation;

internal class Program
{
    static void Main(string[] args)
    {

        // Araba sınıfından car1 adında bir nesne oluşturuldu
        Araba car1 = new Araba();

        // Kullanıcıdan marka bilgisi alınır
        Console.WriteLine("Arabanın Markasını Girin: ");
        car1.Brand = Console.ReadLine();

        // Kullanıcıdan model bilgisi alınır
        Console.WriteLine("Arabanın Modelini Girin: ");
        car1.Model = Console.ReadLine();

        // Kullanıcıdan renk bilgisi alınır
        Console.WriteLine("Arabanın Rengini Girin: ");
        car1.Color = Console.ReadLine();

        // Kullanıcıdan kapı sayı bilgisi alınır ve int'e dönüştürülüp kapsüllü property'e atanır
        Console.WriteLine("Arabanın Kapı Sayısını Girin: ");
        car1.DoorCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Girilen bilgilere göre kaydınız aşağıdaki şekilde oluşturulmuştur.");

        // Kullanıcıdan bilgilerin girilmesini ister
        Console.WriteLine($"Arabanın Markası: {car1.Brand}");
        Console.WriteLine($"Arabanın Modeli: {car1.Model}");
        Console.WriteLine($"Arabanın Rengi: {car1.Color}");
        Console.WriteLine($"Arabanın Kapı Sayısı: {car1.DoorCount}");
    }
}