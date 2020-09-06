using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment01
{
    //test kommentar
    public static class RegExpr
    {
        public static string pattern = "[a-zA-Z0-9]+";

        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                var words = Regex.Matches(line, pattern);
            
                foreach (var word in words)
                {
                    yield return word.ToString();
                }
            }
        }


        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }

    }
}
