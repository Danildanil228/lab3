Console.Write("Введите натуральное число n > 99 = ");
int n = int.Parse(Console.ReadLine());
int n1 = n / 10;
int n2 = (n / 100) % 10;
Console.WriteLine($"Десятков в числе {n} = {n1}");
Console.WriteLine($"Сотен в числе {n} = {n2}");