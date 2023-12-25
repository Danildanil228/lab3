Console.WriteLine("|    x   |   y   |");
for (double x = (-Math.PI)/(4); x <=(7*Math.PI)/(4); x += 0.2)
{
    double y;
    if (x < 0) y = x*x;
    else if (x >= -1 && x <= 1.5) y = 1+3*Math.Log(Math.Abs(1-x*x*x));
    else y = Math.Cos(2.3 * x -1);
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}
