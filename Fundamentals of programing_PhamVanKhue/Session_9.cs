using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_9
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n1. Input String: " + input);

            // 2. Find length of the string without using library function
            int length = 0;
            foreach (char c in input) length++;
            Console.WriteLine("2. Length of String: " + length);

            // 3. Separate individual characters from the string
            Console.WriteLine("3. Individual characters:");
            foreach (char c in input) Console.WriteLine(c);

            // 4. Print individual characters in reverse order
            Console.WriteLine("4. Characters in reverse:");
            for (int i = length - 1; i >= 0; i--) Console.Write(input[i]);
            Console.WriteLine();

            // 5. Count total number of words in the string
            int wordCount = 1;
            for (int i = 0; i < length; i++)
                if (input[i] == ' ') wordCount++;
            Console.WriteLine("5. Total number of words: " + wordCount);

            // 6. Compare two strings without using library functions
            Console.Write("\nEnter another string to compare: ");
            string anotherString = Console.ReadLine();
            bool areEqual = input.Length == anotherString.Length;
            if (areEqual)
            {
                for (int i = 0; i < input.Length; i++)
                    if (input[i] != anotherString[i])
                    {
                        areEqual = false;
                        break;
                    }
            }
            Console.WriteLine("6. Strings are " + (areEqual ? "equal" : "not equal"));

            // 7. Count alphabets, digits, and special characters
            int alphabets = 0, digits = 0, specialChars = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specialChars++;
            }
            Console.WriteLine("7. Alphabets: " + alphabets + ", Digits: " + digits + ", Special Characters: " + specialChars);

            // 8. Count vowels and consonants
            int vowels = 0, consonants = 0;
            foreach (char c in input)
            {
                char lowerC = char.ToLower(c);
                if ("aeiou".Contains(lowerC)) vowels++;
                else if (char.IsLetter(lowerC)) consonants++;
            }
            Console.WriteLine("8. Vowels: " + vowels + ", Consonants: " + consonants);

            // 9. Check for substring presence
            Console.Write("\nEnter a substring to search for: ");
            string substring = Console.ReadLine();
            bool isSubstringPresent = false;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substring.Length; j++)
                    if (input[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                if (match)
                {
                    isSubstringPresent = true;
                    break;
                }
            }
            Console.WriteLine("9. Substring " + (isSubstringPresent ? "found" : "not found"));

            // 10. Find position of substring
            int position = -1;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substring.Length; j++)
                    if (input[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                if (match)
                {
                    position = i;
                    break;
                }
            }
            Console.WriteLine("10. Substring position: " + (position != -1 ? position.ToString() : "not found"));

            // 11. Check if a character is an alphabet and its case
            Console.Write("\nEnter a character to check: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(ch))
                Console.WriteLine("11. '" + ch + "' is an alphabet and is " + (char.IsUpper(ch) ? "uppercase" : "lowercase"));
            else
                Console.WriteLine("11. '" + ch + "' is not an alphabet");

            // 12. Count occurrences of a substring
            int count = 0;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substring.Length; j++)
                    if (input[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                if (match) count++;
            }
            Console.WriteLine("12. Substring occurs " + count + " times");

            // 13. Insert substring before the first occurrence
            if (position != -1)
            {
                string modifiedString = input.Substring(0, position) + substring + input.Substring(position);
                Console.WriteLine("13. Modified string: " + modifiedString);
            }
            else
            {
                Console.WriteLine("13. Substring not found to insert");
            }
        }
    }
}
