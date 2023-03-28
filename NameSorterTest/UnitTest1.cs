using Xunit;
using NameSorter.Models;

namespace NameSorterTest;

public class FullNameTests
{
  [Fact]
  public void AbbComesBeforeAbc()
  {
    string[] nameAbb = { "Abb", "Abb" };
    FullName fullNameAbb = new FullName(nameAbb);

    string[] nameAbc = { "Abc", "Abc" };
    FullName fullNameAbc = new FullName(nameAbc);

    int expected = -1;
    int actual = fullNameAbb.CompareTo(fullNameAbc);

    Assert.Equal(expected, actual);
  }
}