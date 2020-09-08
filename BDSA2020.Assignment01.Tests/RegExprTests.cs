using Xunit;

namespace BDSA2020.Assignment01.Tests
{
    public class RegExprTests
    {

        [Theory]
        [InlineData(new string[] { "These are some words 123", "Here are    more words" }, new string[] { "These", "are", "some", "words", "123", "Here", "are", "more", "words" })]
        public void SplitLineTest(string[] lines, string[] expected)
        {
            var actual = RegExpr.SplitLine(lines);

            var counter = 0;
            foreach (var word in actual)
            {
                Assert.Equal(expected[counter], word);
                counter++;
            }
        }

        [Theory]
        [InlineData("1024x768, 800x600, 640x480", new int[] { 1024, 768, 800, 600, 640, 480 })]
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

        //Only with a-tag
        [Theory]
        [InlineData(@"<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p></div>", "a", new string[] { "theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings" })]
        public void InnerTextTest(string html, string tag, string[] expected)
        {
            var actual = RegExpr.InnerText(html, tag);

            var counter = 0;
            foreach (var result in actual)
            {
                Assert.Equal(expected[counter], result);
                counter++;
            }
        }

        // Nested tags:
        [Theory]
        [InlineData(@"<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>", "p")]
        public void InnerTextNestedTags(string html, string tag)
        {
            var actual = RegExpr.InnerText(html, tag);

            foreach (var result in actual)
            {
                Assert.Equal("The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to.", result);
            }

        }

    }
}
