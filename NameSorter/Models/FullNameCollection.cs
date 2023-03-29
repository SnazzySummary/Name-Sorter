namespace NameSorter.Models
{
  /*
    Models a Collection of FullName objects.
  */
  public class FullNameCollection
  {
    private List<FullName> fullNames;

    /*
      Constructs a FullNameCollection using an array of strings, each string being space separated names.
    */
    public FullNameCollection(string[] inputFullNames)
    {
      fullNames = Array.ConvertAll(inputFullNames, new Converter<string, FullName>(FullName.StringToFullName)).ToList();
    }

    /*
      ToStringArray
      Returns the list of FullName objects as an array of strings, each string being all the names
      of that FullName separated by spaces.
    */
    public string[] ToStringArray()
    {
      return Array.ConvertAll(fullNames.ToArray(), new Converter<FullName, string>(FullName.FullNameToString));
    }

    /*
      Sorts the List of names.
    */
    public void Sort()
    {
      fullNames.Sort();
    }
  }
}