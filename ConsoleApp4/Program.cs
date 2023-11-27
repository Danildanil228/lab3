Console.Write("Введите строку со скобками: ");
string vvod = Console.ReadLine();
int skobka1 = vvod.IndexOf('(');
int skobka2 = vvod.IndexOf(')');
if (skobka1 >= 0 && skobka2 >= 0 && skobka1 < skobka2)
{
    string n = vvod.Substring(skobka1 + 1, skobka2 - skobka1 - 1);
    Console.WriteLine("Содержимое внутри скобок "+n);
}
else Console.WriteLine("В строке нет скобок");
