using System;
using CUT;
using ReallyBadLib;
using Xunit;

namespace ReallyBadTest
{
    #region Zad.4 - Rozwiązanie
    public class ReallyBadTest
    {
        // null
        [Fact]
        public void FirstIndexOf_null()
        {
            var testClass = new ReallyBad();
            Assert.Throws<ArgumentNullException>(() => testClass.FirstIndexOf(null, 'a'));
        }

        [Fact]
        public void LastIndexOf_null()
        {
            var testClass = new ReallyBad();
            Assert.Throws<ArgumentNullException>(() => testClass.LastIndexOf(null, 'a'));
        }

        // pusty strind
        [Fact]
        public void FirstIndexOf_empty()
        {
            var testClass = new ReallyBad();
            var expected = testClass.FirstIndexOf("", 'a');

            Assert.Equal(-1, expected);
        }

        [Fact]
        public void LastIndexOf_empty()
        {
            var testClass = new ReallyBad();
            var expected = testClass.LastIndexOf("", 'a');

            Assert.Equal(-1, expected);
        }

        //brak c w zadanym stringu
        [Fact]
        public void FirstIndexOf_no_char()
        {
            var testClass = new ReallyBad();
            var expected = testClass.FirstIndexOf("abc", 'd');

            Assert.Equal(-1, expected);
        }

        [Fact]
        public void LastIndexOf_no_char()
        {
            var testClass = new ReallyBad();
            var expected = testClass.LastIndexOf("abc", 'd');

            Assert.Equal(-1, expected);
        }

        //ciag dlugosci 1
        [Fact]
        public void FirstIndexOf_one_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.FirstIndexOf("a", 'a');
            Assert.Equal(0, result);
        }

        [Fact]
        public void LastIndexOf_one_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.LastIndexOf("a", 'a');
            Assert.Equal(0, result);
        }

        [Fact]
        public void FirstIndexOf_one_char_not_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.FirstIndexOf("a", 'b');
            Assert.Equal(-1, result);
        }

        [Fact]
        public void LastIndexOf_one_char_not_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.LastIndexOf("a", 'b');
            Assert.Equal(-1, result);
        }

        //pasujacy znak na poczatku
        [Fact]
        public void FirstIndexOf_first_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.FirstIndexOf("abcde", 'a');
            Assert.Equal(0, result);
        }

        [Fact]
        public void LastIndexOf_first_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.LastIndexOf("abcde", 'a');
            Assert.Equal(0, result);
        }

        //pasujacy znak na koncu 
        [Fact]
        public void FirstIndexOf_last_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.FirstIndexOf("abcde", 'e');
            Assert.Equal(4, result);
        }

        [Fact]
        public void LastIndexOf_last_char_matching()
        {
            var testClass = new ReallyBad();
            var result = testClass.LastIndexOf("abcde", 'e');
            Assert.Equal(4, result);
        }

        //wiele wystapien
        [Fact]
        public void FirstIndexOf_multiple_occurrences()
        {
            var testClass = new ReallyBad();
            var result = testClass.FirstIndexOf("abacada", 'a');
            Assert.Equal(0, result);
        }

        [Fact]
        public void LastIndexOf_multiple_occurrences()
        {
            var testClass = new ReallyBad();
            var result = testClass.LastIndexOf("abacada", 'a');
            Assert.Equal(6, result);
        }

    }
    #endregion
}

