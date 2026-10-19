using System;
using System.Collections.Generic;
using CUT;
using Xunit;

namespace CalculatorTest
{
    public class WykladTest
    {
        #region Wykład - Testowanie metod klasy Calculator
        [Fact]
        public void SimpleAdd1()
        {
            // arrange
            int arg1 = 10;
            int arg2 = 2;
            int expected = 12;
            var testClass = new Calculator();

            // act
            double actual = testClass.Add(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Simple_adding_of_integers()
        {
            var sut = new Calculator();
            double actual = sut.Add(10, 2);
            Assert.Equal(12, actual);
        }

        [Fact]
        public void SimpleIntegerDivide()
        {
            // arrange
            int arg1 = 10;
            int arg2 = 2;
            int expected = 5;
            var testClass = new Calculator();

            // act
            int actual = testClass.Divide(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleDoubleDivide()
        {
            // arrange
            double arg1 = 10;
            double arg2 = 2;
            double expected = 5;
            var testClass = new Calculator();

            // act
            double actual = testClass.Divide(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// How to test irrational number with finite precision
        /// </summary>
        [Fact]
        public void IrrationalDoubleDivide()
        {
            // arrange
            double arg1 = 10;
            double arg2 = 3;
            double expected = 3.3333;
            var testClass = new Calculator();

            // act
            double actual = testClass.Divide(arg1, arg2);

            // assert
            Assert.Equal(expected, actual, 0.0001);
        }

        /// <summary>
        ///  How to test with expected exception
        /// </summary>
        [Fact]
        public void IntDivideByZero()
        {
            // arrange
            int arg1 = 10;
            int arg2 = 0;
            var testClass = new Calculator();

            //act
            Action act = () => testClass.Divide(arg1, arg2);

            //assert
            DivideByZeroException exception = Assert.Throws<DivideByZeroException>(act);
            //ArgumentException exception = Assert.Throws<ArgumentException>(act);

            //The thrown exception can be used for even more detailed assertions.
            //Assert.Equal("Attempted to divide by zero.", exception.Message);
        }


        /// <summary>
        /// How to test exceptions without ExpectedException attribiute
        /// </summary>
        [Fact]
        public void IntDivideByZeroWithTry()
        {
            // arrange
            int arg1 = 10;
            int arg2 = 0;
            var testClass = new Calculator();

            // act
            try
            {
                int actual = testClass.Divide(arg1, arg2);
            }
            catch (DivideByZeroException)
            {
                return;
            }
            catch (Exception)
            {
                Assert.Fail("Incorrect exception during dividing by zero");
                return;
            }
            Assert.Fail("The lack of DivideByZero exception");
        }


        // double definie ininity --> divide by 0 = infinity (no exception)
        // int does not have infinity --> divide by 0 thorw exception
        [Fact]
        public void DoubleDivideByZero()
        {
            // arrange
            double arg1 = 10;
            double arg2 = 0;
            var testClass = new Calculator();

            // act
            double actual = testClass.Divide(arg1, arg2);

            Assert.Equal(double.PositiveInfinity, actual);
        }
        #endregion

        #region Wykład - Test Driven Development
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(101)]
        public void Number_is_prime(int number)
        {
            var sut = new Calculator();
            var actual = sut.IsPrime(number);
            Assert.True(actual);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(-4)]
        [InlineData(4)]
        [InlineData(100)]
        public void Number_is_not_prime(int number)
        {
            var sut = new Calculator();
            var actual = sut.IsPrime(number);
            Assert.False(actual);
        }
        #endregion

        #region Wykład - Refaktoryzja
        [Fact]
        public void DaysToEvent_Today_Test()
        {
            DateTime eventDate = new DateTime(2014, 11, 1);
            string expected = "Today";
            var cut = new Utils();
            string actual = cut.DaysToEvent(eventDate);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DaysToEventRefactored_Today_Test()
        {
            DateTime now = new DateTime(2014, 11, 1);
            DateTime eventDate = new DateTime(2014, 11, 1);
            string expected = "Today";
            var cut = new Utils();
            string actual = cut.DaysToEvent_Refactored(now, eventDate);

            Assert.Equal(expected, actual);

        }
        #endregion

        #region Jak testować wiele przypadków na raz?
        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(3, 2, 5)]
        public void AddFromDataRow_Test(int a1, int a2, int expected)
        {
            Calculator cut = new Calculator();
            int actual = cut.Add(a1, a2);

            Assert.Equal<int>(expected, actual);
        }
        #endregion

        #region Comments
        // best practices
        // 1. Don't assume the order in which tests within a test case run
        // 2. Avoid writing test cases with side effects
        // 2.1. They can affect data that other test cases rely upon
        // 2.2. You cannot repeat tests without manual intervention
        // 3. Do not load data from hard-coded locations on a filesystem
        // 4. Ensure that tests are time-independent


        // http://www.slideshare.net/nickokiss/unit-testing-best-practices
        // unit testing best practices
        //3 steps
        //Fast
        //Consistent
        //What code can problem
        //Date currentDate = new Date()
        //int value = Random.NextInt(100);
        //How to deal? Mock, dependency injection
        //Atomic
        //SIngle repsonsibility - one test responsible for one scenarion
        //Test isolation
        //  different execution order - the same result
        //Environment Isolation
        // test should be isolated from environmental infulances
        // database, webservice, environment variables, property files, system date and time
        //Classes isolation
        // how to write testable code?
        // don't call constructor inside a metohd. Use factories or dependency injection
        // use interfaces
        //Fully automated
        //Self descriptive


        //No conditional logic
        // Split the test into 2 or more instead of adding "if" or switch
        //No loops
        //No Exception catching
        // catch an exception only if it is expected
        // catch onle expected type of exception
        // catch expected excpetion and call "fail" method
        // let other exceptions go uncatched
        //Assertions
        //Informative Assertions
        //No test logic in production code
        //Separation per business module
        //Separation per type


        //Error based Techniques: The best person to know the defects in his code is the person who has designed it.
        //    Few of the Error based techniques are:
        //    1. Fault seeding techniques can be used so that known defects 
        //        can be put into the code and tested until they are all found.
        //    2. Mutation Testing: This is done by mutating certain statements in your source code and checking 
        //        if your test code is able to find the errors. 
        //        Mutation testing is very expensive to run, especially on very large applications.
        //    3. Historical Test data: This technique calculates 
        //        the priority of each test case using historical information 
        //        from the previous executions of the test case. 

        #endregion
    }
}
