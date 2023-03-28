using NameSorter.Models;

namespace NameSorter.Services
{
  public static class FullNameSorter
  {
    public static string[] SortNames(string[] lines)
    {
      List<FullName> allNames = FullNameService.StringArrayToFullNameList(lines);
      allNames.Sort();
      return FullNameService.FullNameListToStringArray(allNames);
    }
  }
}