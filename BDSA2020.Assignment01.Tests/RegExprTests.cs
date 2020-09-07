using Xunit;
using System;
using System.Collections.Generic;
using BDSA2020.Assignment01;

namespace BDSA2020.Assignment01.Tests
{
    public class RegExprTests
    {

        [Theory]
        [InlineData(new string[]{"These are some words 123", "Here are    more words"}, new string[]{"These", "are", "some", "words", "123", "Here", "are", "more", "words"})]
        public void SplitLineTest(string[] lines, string[] expected)
        {
            var actual = RegExpr.SplitLine(lines);
            
            var counter = 0;
            foreach(var word in actual)
            {
                Assert.Equal(expected[counter], word);
                counter++;
            }
        }

        [Theory]
        [InlineData("1024x768, 800x600, 640x480", new int[]{1024,768,800,600,640,480})]
        public void ResolutionTest(string resolutions, int[] expected)
        {
            var actual = RegExpr.Resolution(resolutions);

            var counter = 0;
            foreach (var result in actual)
            {
                Assert.Equal(expected[counter], result.width);
                Assert.Equal(expected[counter + 1], result.height);
                counter += 2;
            }


        }



        
        //[InlineData(@""<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href="/wiki/Theoretical_computer_science" title="Theoretical computer science">theoretical computer science</a> and <a href="/wiki/Formal_language" title="Formal language">formal language</a> theory, a sequence of <a href="/wiki/Character_(computing)" title="Character (computing)">characters</a> that define a <i>search <a href="/wiki/Pattern_matching" title="Pattern matching">pattern</a></i>. Usually this pattern is then used by <a href="/wiki/String_searching_algorithm" title="String searching algorithm">string searching algorithms</a> for "find" or "find and replace" operations on <a href="/wiki/String_(computer_science)" title="String (computer science)">strings</a>.</p></div>")];

        //public static string hej = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p></div>";

        [Theory]
        [InlineData(@"<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p></div>", "a")]
        public void InnerTextTest(string html, string tag)
        {
            var actual = RegExpr.InnerText(html, tag);

            foreach (var result in actual)
            {
               
            }
        }

    }
}
