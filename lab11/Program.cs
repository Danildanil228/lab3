public class Airplane
{
    public string Brand { get; set; }
    public int EngineCount { get; set; }
    public double FlightHeight { get; set; }
    public Airplane(string brand, int engineCount, double flightHeight)
    {
        Brand = brand;
        EngineCount = engineCount;
        FlightHeight = flightHeight;
    }
    public double CalculateQuality()
    {
        return EngineCount * FlightHeight / 1000.0;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Самолет: {Brand}, Двигатели: {EngineCount}, Высота Полета: {FlightHeight} метров");
        Console.WriteLine($"Качество: {CalculateQuality()}");
    }
}
public class SpecialAirplane : Airplane
{
    public string CountryOfOrigin { get; set; }
    public SpecialAirplane(string brand, int engineCount, double flightHeight, string countryOfOrigin) : base(brand, engineCount, flightHeight)
    {
        CountryOfOrigin = countryOfOrigin;
    }
    public new double CalculateQuality()
    {
        double baseQuality = base.CalculateQuality();
        if (CountryOfOrigin.Equals("Россия", StringComparison.OrdinalIgnoreCase))
        {
            return baseQuality + 1;
        }
        else if (CountryOfOrigin.Equals("Франция", StringComparison.OrdinalIgnoreCase))
        {
            return baseQuality + 0.5;
        }
        else
        {
            return baseQuality;
        }
    }
    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Страна Производитель: {CountryOfOrigin}");
        Console.WriteLine($"Качество: {CalculateQuality()}");
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите информацию о самолете (класс 1-го уровня):");
            Console.Write("Марка: ");
            string brand1 = Console.ReadLine();
            Console.Write("Количество двигателей: ");
            int engineCount1 = int.Parse(Console.ReadLine());
            Console.Write("Высота полета (метры): ");
            double flightHeight1 = double.Parse(Console.ReadLine());
            Airplane airplane1 = new Airplane(brand1, engineCount1, flightHeight1);
            Console.WriteLine("\nВведите информацию о специальном самолете (класс 2-го уровня):");
            Console.Write("Марка: ");
            string brand2 = Console.ReadLine();
            Console.Write("Количество двигателей: ");
            int engineCount2 = int.Parse(Console.ReadLine());
            Console.Write("Высота полета (метры): ");
            double flightHeight2 = double.Parse(Console.ReadLine());
            Console.Write("Страна производитель: ");
            string countryOfOrigin = Console.ReadLine();
            SpecialAirplane specialAirplane1 = new SpecialAirplane(brand2, engineCount2, flightHeight2, countryOfOrigin);
            Console.WriteLine("\nИнформация о самолете (класс 1-го уровня):");
            airplane1.DisplayInfo();
            Console.WriteLine("\nИнформация о специальном самолете (класс 2-го уровня):");
            specialAirplane1.DisplayInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
