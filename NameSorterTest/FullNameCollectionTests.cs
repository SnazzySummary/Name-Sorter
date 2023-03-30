using Xunit;
using NameSorter.Models;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NameSorterTest;

public class FullNameCollectionTests
{
  /*
    The names should be sorted such that the last names are in the order of aaa, bbb, ccc, eee.
  */
  [Fact]
  public void abceInThatOrder()
  {
    string[] names = { "bbb aaa aaa", "bbb aaa ccc", "aaa bbb bbb", "fff sss eee" };

    FullNameCollection nameCollection = new FullNameCollection(names);
    nameCollection.Sort();
    string[] sortedNames = nameCollection.ToStringArray();
    string[] expectedNames = { "bbb aaa aaa", "aaa bbb bbb", "bbb aaa ccc", "fff sss eee" };

    for (int i = 0; i < names.Length; i++)
    {
      Assert.Equal(sortedNames[i], expectedNames[i]);
    }
  }

  [Fact]
  public void ExtraNamesComeAfter()
  {
    string[] names = { "zzz bbb aaa", "bbb aaa", "zzz bbb aaa" };

    FullNameCollection nameCollection = new FullNameCollection(names);
    nameCollection.Sort();
    string[] sortedNames = nameCollection.ToStringArray();
    string[] expectedNames = { "bbb aaa", "zzz bbb aaa", "zzz bbb aaa" };

    for (int i = 0; i < names.Length; i++)
    {
      Assert.Equal(sortedNames[i], expectedNames[i]);
    }
  }

  /*
    The strings with extra names should be moved down the array and then compared against eachother.
  */
  [Fact]
  public void ExtraNamesAreSortedAndComeAfter()
  {
    string[] names = { "zzz ccc bbb aaa", "ccc bbb aaa", "aaa ccc bbb aaa" };

    FullNameCollection nameCollection = new FullNameCollection(names);
    nameCollection.Sort();
    string[] sortedNames = nameCollection.ToStringArray();
    string[] expectedNames = { "ccc bbb aaa", "aaa ccc bbb aaa", "zzz ccc bbb aaa" };

    for (int i = 0; i < names.Length; i++)
    {
      Assert.Equal(sortedNames[i], expectedNames[i]);
    }
  }

  [Fact]
  public void StringArrayRoundTripDoesNotModify()
  {
    string[] names = { "James Stellar", "Ken John Nordwic" };

    FullNameCollection nameCollection = new FullNameCollection(names);
    string[] namesAfterRoundTrip = nameCollection.ToStringArray();

    string[] expected = { "James Stellar", "Ken John Nordwic" };

    for (int i = 0; i < names.Length; i++)
    {
      Assert.Equal(namesAfterRoundTrip[i], expected[i]);
    }
  }
}