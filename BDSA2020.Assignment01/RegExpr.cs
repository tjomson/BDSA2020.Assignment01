using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment01
{
    //test kommentar
    public static class RegExpr
    {
        public static string wordRegex = "[a-zA-Z0-9]*";

        //TODO not working
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                var words = Regex.Split(line, wordRegex);

                foreach (var word in words)
                {
                    yield return word;
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
