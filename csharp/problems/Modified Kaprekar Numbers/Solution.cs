namespace Problems.ModifiedKaprekarNumbers;


/// <summary>
/// https://www.hackerrank.com/challenges/kaprekar-numbers/problem
/// </summary>
public class Solution : IRunnable<Arguments, string>
{
    public string Run(Arguments arguments)
    {
        int p = arguments.p;
        int q = arguments.q;

        List<int> kaprekar = [];
        for (int number = p; number <= q; number++)
        {
            int d = number.ToString().Length;
            long square = (long)number * number;
            string squareString = square.ToString();
            
            string rString = squareString.Substring(squareString.Length - d);
            string lString = squareString.Substring(0, squareString.Length - d);
            
            int r = int.Parse(rString);
            int l = string.IsNullOrWhiteSpace(lString) ? 0 : int.Parse(lString);
            
            if (r + l == number)
                kaprekar.Add(number);
        }
        
        if (kaprekar.Count == 0)
            return "INVALID RANGE";
        else
            return string.Join(" ", kaprekar);
    }
}