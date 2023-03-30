using NameSorter.Models;
using NameSorter.Services;

namespace NameSorter
{
  class Program
  {
    static void Main(string[] args)
    {
      string inputFilePath = args[0];
      TextFileIO textFileIO = new TextFileIO(inputFilePath, "./sorted-names-list.txt");

      string[] names = textFileIO.ReadLines();
      FullNameCollection allNames = new FullNameCollection(names);
      allNames.Sort();
      string[] sortedNames = allNames.ToStringArray();

      Console.WriteLine(String.Join(Environment.NewLine, sortedNames));
      textFileIO.WriteLines(sortedNames);
    }
  }
}
