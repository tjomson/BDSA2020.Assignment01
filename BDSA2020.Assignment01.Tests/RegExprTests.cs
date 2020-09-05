using Xunit;
using System;
using System.Collections.Generic;
using BDSA2020.Assignment01;

namespace BDSA2020.Assignment01.Tests
{
    public class RegExprTests
    {

        [Theory]
        [InlineData(new string[]{"These are some words 123", "Here are more words"}, new string[]{"These", "are", "some", "words", "123", "Here", "are", "more", "words"})]
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

    }
}
