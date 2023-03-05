Console.WriteLine("Введите последовательно два числа:");
string n1 = Console.ReadLine();
int x1 = int.Parse(n1);

string n2 = Console.ReadLine();
int x2 = int.Parse(n2);

if (x1 > x2)
    {
        Console.Write("Большее число: ");
        Console.Write(x1);
    }
    else
    {
        Console.Write("Большее число: ");
        Console.Write(x2);
    }