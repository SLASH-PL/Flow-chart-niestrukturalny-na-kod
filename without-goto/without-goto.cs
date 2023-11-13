string input = Console.ReadLine();
string[] liczby = input.Split(' ');
int x = int.Parse(liczby[0]);
int y = int.Parse(liczby[1]);
int z = int.Parse(liczby[2]);

while(x > 0 && y > 0)
{
    Console.Write("C");
    y = y - 1;
    x = x - 1;
}

if(x > 0 && y <= 0)
{
    Console.Write("D");
    if (z > 0)
    {
        Console.WriteLine();
    }
    else if(z <= 0)
    {
        Console.Write("G");
        Console.WriteLine();
    }
}
else if (x <= 0)
{
    Console.Write("E");
    Console.Write("G");
    Console.WriteLine();
}
