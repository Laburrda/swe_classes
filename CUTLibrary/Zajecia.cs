using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUT
{
    public class Zajecia
    {
        /// <summary>
        /// Zadanie 1
        /// Receives a number and return true if it is even number 
        /// and false in other case
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public bool IsEven(int arg)
        {
            return arg % 2 == 0;
        }

        /// <summary>
        /// Zadanie 2
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public string ReverseString(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Zadanie 3
        /// return sum of all elements of vector x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int GetSum(int[] x)
        {
            int sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum = sum * x[i];
            }
            return sum;
        }

        public bool IsLeapYear(int year)
        {
            bool isLeap = false;

            // czy to jest jedna instrukcja? tak 
            // można przyjąć, że elementarne warunki logiczne nie wprowadzają nowych instrukcji, 
            // ale wywołania innych metod już tak, np if ((a > 0) && metoda(x) > 2) byłyby dwie instrukcje if i metoda(x)
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                isLeap = true;
            }
            else
            {
                if (year % 400 == 0)
                {
                    isLeap = true;
                }
            }

            return isLeap;

        }


        /// <summary>
        /// Returns an estimated arrival date of a package
        /// Refactor this method in order to remove time dependency. 
        /// After refactoring write simple test
        /// </summary>
        /// <returns></returns>
        public DateTime GetArrivalDate()
        {
            DateTime arrivalDate;
            if (DateTime.Now.DayOfWeek >= DayOfWeek.Thursday)
            {
                arrivalDate = DateTime.Now.Date.AddDays(4);
            }
            else
            {
                arrivalDate = DateTime.Now.Date.AddDays(2);
            }

            return arrivalDate;
        }


        #region Zad.7 - Rozwiązanie cz. II
        
        #endregion
    }
}

