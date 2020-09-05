using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment01
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach(var item in items)
            {
                foreach(var i in item)
                {
                    yield return i; //Måske rigtigt
                }
            }
            
            
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
