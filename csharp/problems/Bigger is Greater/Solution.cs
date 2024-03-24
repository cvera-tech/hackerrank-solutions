using System.Text;

namespace Problems.BiggerIsGreater;

public class Solution : IRunnable<Arguments, string>
{
    public string Run(Arguments arguments)
    {
        string w = arguments.w;

        char[] wChars = w.ToCharArray();

        int[] characterCounts = new int[26];
        int wIndex = wChars.Length - 2;
        // Beginning from the end, check each letter towards the start of the word.
        for (; wIndex >= 0; wIndex--)
        {
            characterCounts[wChars[wIndex + 1] - 'a']++;
            if (wChars[wIndex] < wChars[wIndex + 1])
            {
                char currentLetter = wChars[wIndex];
                // Find the closest larger letter in characterCounts and replace it with the current letter
                for (int countsIndex = currentLetter - 'a' + 1; countsIndex < characterCounts.Length; countsIndex++)
                {
                    if (characterCounts[countsIndex] > 0)
                    {
                        wChars[wIndex] = (char)('a' + countsIndex);
                        characterCounts[countsIndex]--;
                        break;
                    }
                }
                characterCounts[currentLetter - 'a']++;
                break;
            }
        }

        // If we reach the beginning of the word, the word is as big as it can ever be
        if (wIndex < 0)
            return "no answer";

        string newW = new(wChars);
        StringBuilder outputBuilder = new(newW[..(wIndex + 1)]);

        // Rebuild the rest of the word
        for (int countsIndex = 0; countsIndex < characterCounts.Length; countsIndex++)
        {
            int characterCount = characterCounts[countsIndex];
            if (characterCount > 0)
            {
                char charToAppend = (char)('a' + countsIndex);
                for (int charNumber = 0; charNumber < characterCount; charNumber++)
                {
                    outputBuilder.Append(charToAppend);
                }
            }
        }
         
        return outputBuilder.ToString();
    }
}