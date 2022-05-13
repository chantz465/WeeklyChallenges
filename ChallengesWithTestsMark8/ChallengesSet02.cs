using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

                
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var input = vals.Length;
            if (input % 2 == 0)
            { return true; }
            else
                { return false; }

            
        }

        public bool IsNumberEven(int number)
        {
            
            if (number % 2 == 0)
            { return true; }
            else
            { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            
            if (num % 2 == 0)
            { return false; }
            else
            { return true; }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var input = str1.Length;
            var input2 = str2.Length;
            if(input < input2)
                { return input; }
            else
                { return input2; }
        }

        public int Sum(int[] numbers)
        {
            //int numbers2 = 0;
            //foreach (var number in numbers)
            //{ numbers2 = number + number; }
            //return numbers2;
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int number2 =0;
            foreach (var number in numbers)
                
            if (number % 2 == 0)
            { number2 = number + number2; }
            else
            { }
            return number2;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //int number2 = 0;
            //foreach (var number in numbers)
            //    number2 = number + number;
            //if (number2 % 2 == 0)
            //{ return false; }
            //else
            //{ return true; }

            

            return numbers != null && numbers.Count() > 0 && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
