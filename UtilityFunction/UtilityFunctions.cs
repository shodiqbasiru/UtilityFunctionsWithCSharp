namespace UtilityFunction;

public static class UtilityFunctions
{
    public static int CountWords(string str)
    {
        int count = 0;
        char[] letters = str.ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i].Equals(' '))
            {
                count++;
            }
        }

        if (!letters[letters.Length - 1].Equals(' '))
        {
            return count + 1;
        }

        return count;
    }


    public static int MaxNumber(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static int[] SortedNumber(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        return numbers;
    }


    public static char MostLetterShowUp(string str)
    {
        char[] letters = str.ToCharArray();
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int i = 0; i < letters.Length; i++)
        {
            if (dictionary.ContainsKey(letters[i]))
            {
                dictionary[letters[i]]++;
            }
            else
            {
                dictionary.Add(letters[i], 1);
            }
        }

        int max = 0;
        char letter = ' ';
        foreach (var item in dictionary)
        {
            if (item.Value > max)
            {
                max = item.Value;
                letter = item.Key;
            }
        }

        return letter;
    }
}