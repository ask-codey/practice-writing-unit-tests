namespace TestingExercise;

// Small tools for working with words and sentences.
public class WordTools
{
    // Counts the vowels (a, e, i, o, u) in the text, in upper or lower case.
    public int CountVowels(string text)
    {
        int count = 0;
        foreach (char letter in text.ToLower())
        {
            if ("aeiou".Contains(letter))
            {
                count++;
            }
        }
        return count;
    }

    // Whether the text reads the same backward as forward, ignoring spaces and upper or lower case:
    // "level", "Race car" and "Never odd or even" are palindromes.
    public bool IsPalindrome(string text)
    {
        string letters = text.Replace(" ", "");
        for (int i = 0; i < letters.Length / 2; i++)
        {
            if (letters[i] != letters[letters.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
