# Utility Functions

This is a C# project that includes several utility functions.

## Features

- Word Counting: Counts the number of words in a string.
- Maximum Number: Finds the maximum number in an array.
- Number Sorting: Sorts an array of numbers in ascending order.
- Most Frequent Letter: Finds the most frequent letter in a string.

## Usage

```csharp
// CountWords
string str = "Halo, nama saya john doe";
Console.WriteLine(UtilityFunctions.CountWords(str));
        
// MaxNumber
int[] numbers = [1, 5, 3, 7, 2];
Console.WriteLine(UtilityFunctions.MaxNumber(numbers));

// SortedNumber
int[] unsortedNumber = [3, 1, 5, 2, 4];
int[] sortedNumber = UtilityFunctions.SortedNumber(unsortedNumber);
foreach (var number in sortedNumber)
{
    Console.Write(number + " ");
}

// MostLetterShowUp
str = "hello";
char letter = UtilityFunctions.MostLetterShowUp(str);
Console.WriteLine($"\nThe most letter show up is '{letter}' ");
```
