Console.WriteLine("Введите значение для a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение для b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите произведение этих чисел");
int c = int.Parse(Console.ReadLine());
if (c == (a * b))
{
    Console.WriteLine("Верно");
} 
else
{
    Console.WriteLine($"Неверно, {a} x {b} = {a*b}");
}
