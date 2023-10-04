// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
/**Fizz Buzz Logic**/
for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i.ToString() + "..fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i.ToString() + "..fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i.ToString() + "..buzz");
    }
}
/**Fizz Buzz Logic**/
Console.WriteLine("........................");
/**String Reverse**/
Console.Write("Enter string to reverse:");
string input = Console.ReadLine();
Console.WriteLine(input);
StringBuilder reversedinput = new();
for (int i = input.Length - 1; i >= 0; i--)
{
    reversedinput.Append(input[i]);
}
Console.WriteLine(reversedinput.ToString());
/**String Reverse**/