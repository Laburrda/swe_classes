using CUT;
using Xunit;
using System;

namespace NumberHelperTest
{
    public class ZajeciaTest
    {
        #region Zad.1 - Rozwiązanie
        [Fact]
        public void Odd()
        {
            //
            int arg = 5;
            bool expected = false;
            var testClass = new Zajecia();

            //
            bool actual = testClass.IsEven(arg);

            //
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Even()
        {
            //
            int arg = 4;
            bool expected = true;
            var testClass = new Zajecia();

            //
            bool actual = testClass.IsEven(arg);

            //
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Zero()
        {
            //
            int arg = 0;
            bool expected = true;
            var testClass = new Zajecia();

            //
            bool actual = testClass.IsEven(arg);

            //
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Even_negative()
        {
            //
            int arg = -8;
            bool expected = true;
            var testClass = new Zajecia();

            //
            bool actual = testClass.IsEven(arg);

            //
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Odd_negative()
        {
            //
            int arg = -9;
            bool expected = false;
            var testClass = new Zajecia();

            //
            bool actual = testClass.IsEven(arg);

            //
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Zad.2 - Rozwiązanie
        [Fact]
        public void Normal_String()
        {
            var input = "hello";
            var expected = "olleh";
            var testClass = new Zajecia();

            var result = testClass.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_String()
        {
            var input = "";
            var expected = "";
            var testClass = new Zajecia();

            var result = testClass.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Single_char()
        {
            var input = "A";
            var expected = "A";
            var testClass = new Zajecia();

            var result = testClass.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void String_with_whitespace()
        {
            var input = "abc def";
            var expected = "fed cba";
            var testClass = new Zajecia();

            var result = testClass.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Special_characters()
        {
            var input = "ąęć";
            var expected = "ćęą";
            var testClass = new Zajecia();

            var result = testClass.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Null_exception()
        {
            var testClass = new Zajecia();

            Assert.Throws<ArgumentNullException>(() => testClass.ReverseString(null));
        }

        #endregion

        #region Zad.3 - Rozwiązanie

        [Fact]
        public void Test_ujawniajacy_wade()
        {
            int[] input = new int[] { 1, 2, 4 };
            int expected = 7;
            var testClass = new Zajecia();

            var result = testClass.GetSum(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_nieujawniajacy_wady()
        {
            int[] input = new int[] { 1, 2, 3 };
            int expected = 6;
            var testClass = new Zajecia();

            var result = testClass.GetSum(input);

            Assert.Equal(expected, result);
        }
        #endregion

        #region Zad.4 - Rozwiązanie
        // Rozwiązanie zadania 4 umieścić w projekcie ReallyBadTest
        #endregion

        #region Zad.5 - Rozwiązanie

        [Theory]
        [InlineData(2025, 7, 31)]   // lipiec
        [InlineData(2024, 12, 31)]  // grudzień
        [InlineData(2023, 8, 31)]   // sierpień
        [InlineData(2022, 1, 31)]   // styczeń
        [InlineData(2021, 4, 30)]   // kwiecień
        [InlineData(2024, 2, 29)]   // luty – rok przestępny
        public void DaysInMonth_Test(int year, int month, int expected)
        {
            //
            int result = DateTime.DaysInMonth(year, month);

            //
            Assert.Equal(expected, result);
        }

        #endregion

        #region Zad.6 - Rozwiązanie
        // Rozwiązanie zadania 6 umieścić w projekcie GameTest
        #endregion

        #region Zad.7 - Rozwiązanie - cz. I

        #endregion

        #region Zad.8 - Rozwiązanie
        // zadanie do zrobienia na tablicy
        #endregion

        #region Zad.9 - Rozwiązanie
        // zadanie do zrobienia na tablicy
        #endregion

        #region Zad.10 - Rozwiązanie

        #endregion

        #region Zad.11 - Rozwiązanie
        // Rozwiązanie zadania 11 umieścić w projekcie SentenceTest 
        #endregion
    }
}

