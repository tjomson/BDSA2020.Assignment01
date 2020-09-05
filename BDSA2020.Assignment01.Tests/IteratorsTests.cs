using Xunit;
using System;
using System.Collections.Generic;
using BDSA2019.Assignment01;

namespace BDSA2020.Assignment01.Tests
{
    public class IteratorsTests
    {
        [Theory]
        [InlineData(1, 2, 3, 4, 5, 6)]
        [InlineData(0, -1, 7, 3.98, -200, 29)]
        public void FlattenTest(int a, int b, int c, int d, int e, int f)
        {
            var list = new List<List<int>>();
            var expected = new int[] { a, b, c, d, e, f };

            list.Add(new List<int>(){
                a,b,c
            });

            list.Add(new List<int>(){
                d,e,f
            });


            int counter = 0;
            foreach (var item in Iterators.Flatten(list))
            {
                Assert.Equal(expected[counter], item);
                counter++;
            }

        }

        [Theory]
        [InlineData(new int[]{1,2,3,4}, new int[]{2,4})]
        [InlineData(new int[]{-5,-8,1001,0}, new int[]{-8, 0})]
        public void FilterTest(int[] input, int[] expected)
        {

            Predicate<int> even = Even;
            
            var actual = Iterators.Filter(input, even);

            var counter = 0;
            foreach(var item in actual)
            {
                Assert.Equal(expected[counter], item);
                counter++;
            }

        }

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
