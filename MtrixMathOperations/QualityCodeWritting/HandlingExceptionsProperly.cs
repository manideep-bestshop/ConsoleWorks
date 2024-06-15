using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCodeWritting
{
    public class FileReader
    {
        public string ReadFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            try
            {
                return System.IO.File.ReadAllText(filePath);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                throw new InvalidOperationException("specified file not found.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("error occurred while reading  file.", ex);
            }
        }
    }
    internal class HandlingExceptionsProperly
    {
        static void Main()
        {
            FileReader fileReader = new FileReader();

            try
            {
                string content = fileReader.ReadFile("example.txt");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
