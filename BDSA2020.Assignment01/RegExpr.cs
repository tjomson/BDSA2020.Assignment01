using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment01
{
    public static class RegExpr
    {
        public static string wordRegex = "[a-zA-Z0-9]+";

        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                var words = Regex.Matches(line, wordRegex);
            
                foreach (var word in words)
                {
                    yield return word.ToString();
                }
            }
        }

        public static string resolutionRegex = "(?<width>\\d+)[x](?<height>\\d+)";
        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var result = Regex.Matches(resolutions, resolutionRegex);

            foreach (Match match in result)
            {
                var width = Int32.Parse(match.Groups["width"].Value);
                var height = Int32.Parse(match.Groups["height"].Value);
                yield return (width, height);
            }

        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            string regex = $@"<({tag})>(?<result>.*?)<\/\1>";
            string replacePattern = "<.*?>";
            var matches = Regex.Matches(html, regex);

            foreach (Match match in matches)
            { 
                var result = match.Groups["result"].Value;
                yield return Regex.Replace(result, replacePattern, "");
            
            }

        }

    }
}
