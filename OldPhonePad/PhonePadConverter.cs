using System;
using System.Collections.Generic;

namespace OldPhonePad;

public class PhonePadConverter
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string output = OldPhonePad(input);
        Console.WriteLine(output);
    }

    // Input validation method
    public static bool IsInputValid(string input)
    {
        if (input == null)
        {
            return false;
        }
        foreach (char c in input)
        {
            if (!char.IsDigit(c) && c != '*' && c!= '#' && c != ' ')
            {
                return false;
            }
        }
        return true;
    }

    // A dictionary to keep the keypad mapping
    public static string OldPhonePad(string input)
    {
        if (!IsInputValid(input))
        {
            return "Please enter a valid input!";
        }
        Dictionary<char, string> numPad = new Dictionary<char, string>{
             {'0', " 0"},
             {'1', "&'(1"},
             {'2', "abc2"},
             {'3', "def3"},
             {'4', "ghi4"},
             {'5', "jkl5"},
             {'6', "mno6"},
             {'7', "pqrs7"},
             {'8', "tuv8"},
             {'9', "wxyz9"}
         };

        string output = "";

        // Ignoring the #
        string text = input.Substring(0, input.IndexOf("#"));

        int i = 0;
        int j = 0;

        // Iterating the string
        while (j < text.Length)
        {
            // Ignoring whitespace
            if (text[i] == ' ')
            {
                i++;
                j++;
                continue;
            }
            // Counting number of identical continuous key presses      
            while (j < text.Length && text[i] == text[j])
            {
                j++;
            }
            // Handling backspace	
            if (text[i] == '*')
            {
                // If the number of backspaces is greater than the output length, remove everything
                if (output.Length <= (j - i))
                {
                    output = "";
                }
                else
                {
                    // Stripping out one character for every backspace
                    output = output.Substring(0, output.Length - (j - i));
                }
            }
            else
            {
                // We find the key, then take the mod of the count 
                // with respect to the total number of possible characters 
                // in that key (minus one as index starts from 0) to find the intended character, 
                // and convert it to string before appending after the output
                output += numPad[text[i]][(j - i - 1) % numPad[text[i]].Length].ToString();
            }
            i = j;
        }

        return output;
    }
}