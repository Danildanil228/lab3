Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
int x = Convert.ToInt32("1101011", 2);  
switch (n)
{
    case 1:
        {
            int a = 10, b = 34, c = 65;
            if (a > x) Console.WriteLine($"{a}>{x}");
            if (b > x) Console.WriteLine($"{b}>{x}");
            if (c > x) Console.WriteLine($"{c}>{x}");
            else Console.WriteLine("Нет таких чисел");
        }
        break;
    case 2:
        {
            int a = 76, b = 18, c = 55;
            if (a > x) Console.WriteLine($"{a}>{x}");
            if (b > x) Console.WriteLine($"{b}>{x}");
            if (c > x) Console.WriteLine($"{c}>{x}");
            else Console.WriteLine("Нет таких чисел");
        }
        break;
    case 3:
        {
            int a = 81, b = 75, c = 20;
            if (a > x) Console.WriteLine($"{a}>{x}");
            if (b > x) Console.WriteLine($"{b}>{x}");
            if (c > x) Console.WriteLine($"{c}>{x}");
            else Console.WriteLine("Нет таких чисел");
        }
        break;
        
}
