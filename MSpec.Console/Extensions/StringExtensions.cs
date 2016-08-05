using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MSpec.Console.Extensions
{
    public static class StringExtensions
    {
        public static string Translate(this string wordToTranslate)
        {
            if (wordToTranslate.Length == 1)
                return wordToTranslate;

            var firstLetter = wordToTranslate.First();
            var lastLetter = wordToTranslate.Last();
            var middleLetters = wordToTranslate.Skip(1).Take(wordToTranslate.Length - 2);
            var distinctLetters = middleLetters.Distinct();

            var translatedWord =
                $"{firstLetter}{distinctLetters.Count()}{lastLetter}";

            return translatedWord;
        }

        public static List<string> ParseSentence(this string sentenceToParse)
        {
            var words = new List<string>();
            var expression = @"(\w+|[,-?]|.)";
            var regEx = new Regex(expression);

            if (regEx.IsMatch(sentenceToParse))
            {
                var matches = regEx.Matches(sentenceToParse);

                words.AddRange(from Match match in matches select match.Groups[1].Value);
            }

            return words;
        }
    }
}
