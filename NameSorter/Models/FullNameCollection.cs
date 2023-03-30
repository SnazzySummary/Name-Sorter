namespace NameSorter.Models
{
  /*
    Holds a Collection of FullName objects.
  */
  public class FullNameCollection
  {
    private List<FullName> fullNames = new List<FullName>();

    /*
      Constructs a FullNameCollection using an array of strings, each string being space separated names.
      Params:
      fullNames - An array of strings, each string containing space separated names.
    */
    public FullNameCollection(string[] fullNames)
    {
      for (int i = 0; i < fullNames.Length; i++)
      {
        this.fullNames.Add(new FullName(fullNames[i]));
      }
    }

    /*
      Returns the list of FullNames in the form of an array of strings.
      Returns:
      string[] - an array of strings, each string containing space separated names.
    */
    public string[] ToStringArray()
    {
      string[] names = new string[fullNames.Count];
      for (int i = 0; i < fullNames.Count; i++)
      {
        names[i] = fullNames[i].ToString();
      }

      return names;
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