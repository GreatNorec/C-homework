Console.WriteLine("Enter the number");
string n = Console.ReadLine();
int h = int.Parse(n);

string s ="";
for (int i = 1; i < h+1; i++)
    {
        if ( i%2 == 0 )
        {
            s = i + " ";
            Console.Write(s);
        }
    }