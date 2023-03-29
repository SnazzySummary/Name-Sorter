using Xunit;
using NameSorter.Models;
using System;
using System.Reflection;

namespace NameSorterTest;

public class FullNameTests
{
  [Fact]
  public void AbbComesBeforeAbc()
  {
    FullName Abb = new FullName("Jane Abb");
    FullName Abc = new FullName("Marcy Abc");

    int expected = -1;
    int actual = Abb.CompareTo(Abc);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void AbEqualsAb()
  {
    FullName Ab1 = new FullName("John Ab");
    FullName Ab2 = new FullName("John Ab");

    int expected = 0;
    int actual = Ab1.CompareTo(Ab2);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void LastNamesEqualButAnnIsBeforeBruce()
  {
    FullName Bruce = new FullName("Bruce Ab");
    FullName Ann = new FullName("Ann Ab");

    int expected = 1;
    int actual = Bruce.CompareTo(Ann);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void BruceHasMoreNames()
  {
    FullName Bruce = new FullName("Bruce Baker Ann Ab");
    FullName Ann = new FullName("Ann Ab");

    int expected = 1;
    int actual = Bruce.CompareTo(Ann);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void AnnHasMoreNames()
  {
    FullName Bruce = new FullName("Bruce Ab");
    FullName Ann = new FullName("Ann Sam Bruce Ab");

    int expected = -1;
    int actual = Bruce.CompareTo(Ann);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void OneIsNotAFullName()
  {
    FullName Bruce = new FullName("Bruce Ab");
    string Ann = "Ann Ab";

    Action action = () => Bruce.CompareTo(Ann);

    ArgumentException exception = Assert.Throws<ArgumentException>(action);

    Assert.Equal("Object is not a FullName", exception.Message);
  }
}