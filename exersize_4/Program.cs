Console.WriteLine("Enter three numbers");

string n1 = Console.ReadLine();
int x1 = int.Parse(n1);

string n2 = Console.ReadLine();
int x2 = int.Parse(n2);

string n3 = Console.ReadLine();
int x3 = int.Parse(n3);

int[] M = { x1, x2, x3};
int max = M[0];

for (int i = 1; i < 3; i++)
{
    if (max < M[i])
    {
        max = M[i];
    }
}
Console.WriteLine(max);