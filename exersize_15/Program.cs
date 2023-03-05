Console.Write("Enter the number of the day of the week: ");
string num = Console.ReadLine();
int n = int.Parse(num);
string[] M = { "No", "No", "No", "No", "No", "Yes", "Yes"};
Console.WriteLine("Is it today day off? - " + M[n-1]);