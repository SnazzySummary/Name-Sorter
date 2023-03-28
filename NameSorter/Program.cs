// See https://aka.ms/new-console-template for more information
using NameSorter.Models;

Console.WriteLine("Hello, World!");

string[] name1_Names = { "Abc", "Abc" };
FullName name1 = new FullName(name1_Names);

string[] name2_Names = { "Meow", "Abb" };
FullName name2 = new FullName(name2_Names);

if (name1.CompareTo(name2) < 0)
{
  Console.WriteLine(name1.ToString());
  Console.WriteLine(name2.ToString());
}
else
{
  Console.WriteLine(name2.ToString());
  Console.WriteLine(name1.ToString());
}
