namespace NameSorter.Services
{
  public static class TextFileIO
  {
    public static string[] ReadLines(string filePath)
    {
      return File.ReadAllLines(filePath);
    }

    public static void WriteLines(string filePath, string[] lines)
    {
      File.WriteAllText(filePath, String.Join(Environment.NewLine, lines));
    }
  }
}