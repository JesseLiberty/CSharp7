using System;
using static System.ConsoleColor;
using static System.IO.Directory;
using static System.Threading.Interlocked;
using static System.Threading.Tasks.Parallel;
public static class Program
{
    // ...
    public static void Main(string[] args)
    {
        // Parameter checking eliminated for elucidation.
        EncryptFiles(args[0], args[1]);
    }
    public static int EncryptFiles(
      string directoryPath, string searchPattern = "*")
    {
        ConsoleColor color = ForegroundColor;
        int fileCount = 0;
        try
        {
            ForegroundColor = Yellow;
             WriteLine("Start encryption...");
            string[] files = GetFiles(directoryPath, searchPattern,
              System.IO.SearchOption.AllDirectories);
            ForegroundColor = White;
          ForEach(files, (filename) =>
      {
          Encrypt(filename);
          WriteLine("\t'{0}' encrypted", filename);
          Increment(ref fileCount);
      });
            ForegroundColor = Yellow;
          WriteLine("Encryption completed");
        }
        finally
        {
            ForegroundColor = color;
        }
        return fileCount;
    }
}
