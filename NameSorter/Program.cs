using NameSorter.Models;
using NameSorter.Services;

namespace NameSorter
{
  class Program
  {
    static void Main(string[] args)
    {
      string inputFilePath = args[0];
      string[] names = TextFileIO.ReadLines(inputFilePath);

      FullNameCollection allNames = new FullNameCollection(names);
      allNames.Sort();
      string[] sortedNames = allNames.ToStringArray();

      Console.WriteLine(String.Join(Environment.NewLine, sortedNames));
      TextFileIO.WriteLines("./sorted-names-list.txt", sortedNames);
    }
  }
}
