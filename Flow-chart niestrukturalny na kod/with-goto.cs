using System.ComponentModel.Design;

string input = Console.ReadLine();
string[] liczby = input.Split(' ');
int x = int.Parse(liczby[0]);
int y = int.Parse(liczby[1]);
int z = int.Parse(liczby[2]);

Start:
if(x > 0)
{
    if(y > 0)
    {
        Console.Write("C");
        x = x - 1;
        y = y - 1;
        goto Start;
    }
    else if(y <= 0)
    {
        Console.Write("D");
        if(z > 0) 
        {
            Console.WriteLine();
        }
        else if(z <= 0) 
        {
            Console.Write("G");
            Console.WriteLine();
        }
    }
}
else if(x <= 0)
{
    Console.Write("E");
    Console.Write("G");
    Console.WriteLine();
}