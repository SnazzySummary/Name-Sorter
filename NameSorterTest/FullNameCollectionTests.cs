using Xunit;
using NameSorter.Models;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NameSorterTest;

public class FullNameCollectionTests
{
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
}