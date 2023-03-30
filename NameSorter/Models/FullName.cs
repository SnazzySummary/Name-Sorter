namespace NameSorter.Models
{
  /*
    Models a persons given names and surname.
  */
  public class FullName : IComparable
  {
    // An array of names.
    private string[] names;

    /*
      Constructs a FullName using a string of space separated names.
      Params:
      inputNames - a string of space separated names.
    */
    public FullName(string inputNames)
    {
      string[] nameArray = inputNames.Split(' ');
      names = nameArray;
    }

    /*
      CompareTo Override
      Compares each FullName alphabetically, starting from the last name and ending at the first.
      Params:
      obj - Another FullName object to compare to.
      Returns:
      int - an integer that indicates whether the value of this instance is less than,
            equal to, or greater than the value of the specified object or the other.
    */
    public int CompareTo(object? obj)
    {
      if (obj == null) return 1;
      FullName? otherFullName = obj as FullName;
      if (otherFullName != null)
      {
        string[] otherNames = otherFullName.names;

        // Start with the last name of each FullName object.
        int lastNamePointer = names.Length - 1;
        int otherLastNamePointer = otherNames.Length - 1;

        // Compare all names until one of the pointers passes 0 or a difference is found.
        while (lastNamePointer >= 0 && otherLastNamePointer >= 0)
        {

          int compared = names[lastNamePointer].CompareTo(otherNames[otherLastNamePointer]);

          // If a difference is found, return the difference.
          if (compared != 0)
          {
            return compared;
          }
          else
          {
            // Move to the next name.
            lastNamePointer--;
            otherLastNamePointer--;
          }
        }

        /*
          If one pointer runs out of names but the other has some left, the one with
          more names comes after.
        */
        if (lastNamePointer >= 0)
        {
          return 1; // This FullName has more names and comes after the Other one.
        }
        else if (otherLastNamePointer >= 0)
        {
          return -1; // The other FullName has more names and comes after this one.
        }
        else
        {
          return 0;
        }
      }
      else
      {
        throw new ArgumentException("Object is not a FullName");
      }
    }

    /*
      ToString override
      Returns:
      string - a space separated string of names.
    */
    public override string ToString()
    {
      int lastNameIndex = names.Length - 1;

      string output = names[0];
      for (int i = 1; i <= lastNameIndex; i++)
      {
        output += " " + names[i];
      }

      return output;
    }
  }
}