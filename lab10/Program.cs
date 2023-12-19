public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int YearOfManufacture { get; set; }
    public Product(string name, decimal price, int yearOfManufacture)
    {
        Name = name;
        Price = price;
        YearOfManufacture = yearOfManufacture;
    }
    public virtual string GetInformation()
    {
        return $"Имя: {Name}, Цена: {Price}, Год выпуска: {YearOfManufacture}";
    }
}
public class BrandedProduct : Product
{
    public DateTime ArrivalDate { get; set; }
    public BrandedProduct(string name, decimal price, int yearOfManufacture, DateTime arrivalDate)
        : base(name, price, yearOfManufacture)
    {
        ArrivalDate = arrivalDate;
    }
    public int DaysAfterManufactureYear()
    {
        DateTime currentDate = DateTime.Now;
        TimeSpan difference = currentDate - new DateTime(YearOfManufacture, 1, 1);
        return difference.Days;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите название продукта: ");
        string genericProductName = Console.ReadLine();
        Console.Write("Введите цену: ");
        decimal genericProductPrice = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите год выпуска: ");
        int genericProductYear = Convert.ToInt32(Console.ReadLine());
        Product product = new Product(genericProductName, genericProductPrice, genericProductYear);
        Console.WriteLine(product.GetInformation());
        Console.Write("Введите имя фирменного продукта: ");
        string brandedProductName = Console.ReadLine();
        Console.Write("Введите цену: ");
        decimal brandedProductPrice = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите год выпуска: ");
        int brandedProductYear = Convert.ToInt32(Console.ReadLine());
        BrandedProduct brandedProduct = new BrandedProduct(brandedProductName, brandedProductPrice, brandedProductYear, DateTime.Now);
        Console.WriteLine(brandedProduct.GetInformation());
        Console.WriteLine($"Дней после выпуска: {brandedProduct.DaysAfterManufactureYear()}");
    }
}
