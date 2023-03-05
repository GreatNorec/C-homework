Console.WriteLine("Enter three-digit number");
string n = Console.ReadLine();
int num = int.Parse(n);

int num1 = num%100;
Console.Write("remainder of the division by 100 is ");
Console.Write(num1);
Console.WriteLine();

int num2 = num%10;
Console.Write("remainder of the division by 10 is ");
Console.Write(num2);
Console.WriteLine();

int result = (num1 - num2) / 10;
Console.Write("second number is ");
Console.Write(result);