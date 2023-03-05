Console.WriteLine("Enter any number");
string M = Console.ReadLine();

int[] b = new int[M.Length];
for( int i=0; i< M.Length; i++)
{
     b[i] = int.Parse(M[i].ToString());
}

if ( b.Length > 2) Console.WriteLine(b[2]);
else Console.WriteLine("Third number does not exist");