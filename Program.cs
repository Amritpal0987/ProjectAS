using System;
namespace PrecedenceEx
{
class Program
{
static void Main(string[] args)
{
int a, b, c;
string Sname, id;
Console.WriteLine("Enter your name and ID");
Sname = Console.ReadLine();
id= Console.ReadLine();
Console.WriteLine("Enter 3 integer numbers :");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
int expr1 = a + (7 * b);
int expr2 = (a + 7) * b;
int expr3 = (c / a) + 4;
int expr4 = (c - (a % b)) - a;
int expr5 = (c - a) % (b - a);
Console.WriteLine(" a + (7 * b) = {0}", expr1);
Console.WriteLine("(a + 7) * b = {0}", expr2);
Console.WriteLine("(c / a) + 4) = {0}", expr3);
Console.WriteLine("(c - (a % b)) - a = {0}", expr4);
Console.WriteLine("(c - a) % (b - a) = {0}", expr5);
Console.ReadKey();
}
}
}