using NameSorter.Models;

namespace NameSorter.Services
{
  public static class FullNameService
  {
    private static FullName StringToFullName(string names)
    {
      return new FullName(names);
    }

    private static string FullNameToString(FullName fullName)
    {
      return fullName.ToString();
    }

    public static List<FullName> StringArrayToFullNameList(string[] fullNames)
    {
      return Array.ConvertAll(fullNames, new Converter<string, FullName>(StringToFullName)).ToList();
    }

    public static string[] FullNameListToStringArray(List<FullName> fullNames)
    {
      return Array.ConvertAll(fullNames.ToArray(), new Converter<FullName, string>(FullNameToString));
    }
  }
}