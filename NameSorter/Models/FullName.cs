namespace NameSorter.Models
{
  /*
    Models a persons given names and surname.
  */
  public class FullName : IComparable
  {
    // An array of names, the last being a surname.
    private string[] names;

    /*
      Constructor for FullName
      Params:
      nameArray - An array of strings, the first being given names, the last being a surname.
    */
    public FullName(string inputNames)
    {
      string[] nameArray = inputNames.Split(' ');
      names = nameArray;
    }

    /*
      ToString override
      Returns a space separated string of each name, the last bieng a surname.
    */
    public override String ToString()
    {
      int lastNameIndex = names.Length - 1;

      String output = names[0];
      for (int i = 1; i <= lastNameIndex; i++)
      {
        output += " " + names[i];
      }

      return output;
    }

    /*
      CompareTo Override
      Compares each name in the FullName first by last name, then by any given names the person may have.
      As soon as an alphabetical difference is found, that difference is returned.
      If no difference is found, 0 is returned.
    */
    public int CompareTo(object? obj)
    {
      if (obj == null) return 1;

      FullName? otherFullName = obj as FullName;
      if (otherFullName != null)
      {
        // Compare the names with string.CompareTo
        string[] otherNames = otherFullName.names;

        int lastNameIndex = names.Length - 1;
        int otherLastNameIndex = otherNames.Length - 1;

        // Start with last name, if equal, move back one name and retry
        while (lastNameIndex >= 0 && otherLastNameIndex >= 0)
        {
          // Result of current comparison
          int compared = names[lastNameIndex].CompareTo(otherNames[otherLastNameIndex]);

          if (compared != 0)
          {
            return compared;
          }
          else
          {
            lastNameIndex--;
            otherLastNameIndex--;
          }
        }
        return 0;
      }
      else
      {
        throw new ArgumentException("Object is not a FullName");
      }
    }

    /*
      StringToFullName
      Takes a String of space separated names and returns a FullName object.
    */
    public static FullName StringToFullName(string names)
    {
      return new FullName(names);
    }

    /*
      StringToFullName
      Takes a FullName object and returns a String of space separated names.
    */
    public static string FullNameToString(FullName fullName)
    {
      return fullName.ToString();
    }
  }
}