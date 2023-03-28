using NameSorter.Services;

namespace NameSorter
{
  class Program
  {
    static void Main(string[] args)
    {
      string inputFilePath = args[0];
      string[] names = TextFileIO.ReadLines(inputFilePath);
      string[] sortedNames = FullNameSorter.SortNames(names);

      Console.WriteLine(String.Join(Environment.NewLine, sortedNames));
      TextFileIO.WriteLines("./sorted-names-list.txt", sortedNames);
    }
  }
}
