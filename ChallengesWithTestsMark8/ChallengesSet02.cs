using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //could also just do "return vals.Length % 2 == 0;" because the default of a bool is "true"
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //same thing here, could do "return number % 2 == 0;"
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //"return num % 2 != 0;"
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            double min = numbers.Min();
            double max = numbers.Max();
            return min + max;
            //or "return numbers.Min() + numbers.Max();" instead of making the variables
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return (numbers.Sum() % 2 == 0); is more CCR than the foreach loop with defining the sum
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }

            if (number % 2 != 0)
            {
                return (number - 1) / 2;
            }
            else
            {
                return number / 2;
            }
            //or int count = 0;
            //for (int i = 1; i < number; i +=2)
            //{ count++; }
            //return count;
        }
    }
}
