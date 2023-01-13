using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
                if (item % 2 != 0)
                {
                    sum -= item;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var array = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return array.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var array = new int[] { number1, number2, number3, number4 };
            return array.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int sum1and2 = sideLength1 + sideLength2;
            int sum1and3 = sideLength1 + sideLength3;
            int sum2and3 = sideLength2 + sideLength3;
            if (sum1and2 <= sideLength3 || sum1and3 <= sideLength2 || sum2and3 <= sideLength1)
            {
                return false;
            }
            else { return true; }
        }

        public bool IsStringANumber(string input)
        {
            bool stringIsANumber = double.TryParse(input, out var number);
            if (stringIsANumber)
            {
                return true;
            }
            else { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = objs.Count(x => x == null);
            if (count > (objs.Length / 2))
            {
                return true;
            }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double sumOfEvens = 0;
            int countOfEvens = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sumOfEvens += item;
                    countOfEvens++;
                }
            }
            if (countOfEvens == 0) 
            { 
                return 0;
            }
            double avgOfEvens = sumOfEvens / countOfEvens;
            return avgOfEvens; 
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {
                number = number * i;
                
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
