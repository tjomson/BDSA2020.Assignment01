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

    }
}
