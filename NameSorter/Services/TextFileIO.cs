namespace NameSorter.Services
{
  /*
    TextFileIO
    Reads and Writes an array of strings to the specified files. Each string is a line in the text file.
  */
  public class TextFileIO
  {
    private string inputFilePath;
    private string outputFilePath;

    /*
      Constructs the TextFileIO object with specified input and output file paths.
      Params:
      inputFilePath - a string representing the filePath to read from.
      outputFilePath - a string representing the filePath to write to.
    */
    public TextFileIO(string inputFilePath, string outputFilePath)
    {
      this.inputFilePath = inputFilePath;
      this.outputFilePath = outputFilePath;
    }

    /*
      Reads the input text file and returns and array of strings. Each string is a line of the file.
    */
    public string[] ReadLines()
    {
      return File.ReadAllLines(inputFilePath);
    }

    /*
      Writes each string from the given array as a line in the output text file.
      Params:
      lines - an array of strings, each representing a line of text to write.
    */
    public void WriteLines(string[] lines)
    {
      File.WriteAllText(outputFilePath, String.Join(Environment.NewLine, lines));
    }
  }
}