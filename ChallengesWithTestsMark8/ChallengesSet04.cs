using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            //var digit = 0;
            //foreach(var n in numbers)
            //{
            //    if (n % 2 == 0)
            //    {
            //        digit += n;
            //    }
            //    else
            //    {
            //        digit -= n;
            //    }
            //}
            //return digit;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortString = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return shortString.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var shortNum = new List<int> { number1, number2, number3, number4 };
            return shortNum.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 
               && sideLength1 + sideLength3 > sideLength2 
               && sideLength2 + sideLength3 > sideLength1)
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);

            //var nullAmount = 0;
            //var nonNull = 0;

            //foreach (object _o in objs)
            //{
            //    if (_o == null)
            //    {
            //        nullAmount++;
            //    }
            //    else
            //    {
            //        nonNull++;
            //    }
            //}
            //return nullAmount > nonNull ? true : false;

        //    var ojb = objs.Length;
        //    var majority = (amount / 2) + 1;
        //    var count = 0;
        //    foreach ( var obj in objs)
        //    {
        //        if (obj == null)
        //        {
        //            count++;
        //        }
        //    }
        }/*return count >=*/ 

        public double AverageEvens(int[] numbers)
        {
            return numbers == null ? numbers.Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0).Average() : 0;
        }

        public int Factorial(int number)
        {           
            return number == 0 ? 1 : number * Factorial(number - 1);

            //var factorial = 1;
            //if (number < 0)
            //{
            //    throw new ArgumentOutOfRangeException();

            //}
            //for (int f = number; f > 0; f--)
            //    factorial *= f;
            //        return factorial;
        }
    }
}
