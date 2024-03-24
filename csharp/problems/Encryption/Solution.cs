using System.Text;

namespace Problems.Encryption;

public class Solution : IRunnable<Arguments, string>
{
    public string Run(Arguments arguments)
    {
        string s = arguments.s;

        int rows = (int)Math.Floor(Math.Sqrt(s.Length));
        int cols = (int)Math.Ceiling(Math.Sqrt(s.Length));
        
        while(rows * cols < s.Trim().Length)
        {
            if (rows < cols)
                rows++;
            else
                cols++;
        }
        
        char[] noSpaces = string.Join("", s.Split(' ')).ToCharArray();
        char[,] matrix = new char[rows, cols];
        for (int index = 0; index < noSpaces.Length; index++)
        {
            matrix[index / cols, index % cols] = noSpaces[index];
        }
        
        StringBuilder outputBuilder = new();
        StringBuilder wordBuilder = new();
        for (int colIndex = 0; colIndex < cols; colIndex++)
        {
            if (colIndex > 0)
                outputBuilder.Append(' ');
            wordBuilder.Clear();
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                char c = matrix[rowIndex, colIndex];
                if (c != '\0')
                    wordBuilder.Append(c);
            }
                
            outputBuilder.Append(wordBuilder);
        }
        return outputBuilder.ToString();
    }
}